using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjectSpy
{
    /// <summary>
    /// Description: This class is to identify locator of WebElement automatically
    /// Issue: Could NOT handle popup frame window
    /// Author: Yongfei.Hu
    /// </summary>
    public partial class objectSpy : Form
    {
        HtmlDocument frame;
        string frameName, frameId;
        public objectSpy()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Document.MouseOver += new HtmlElementEventHandler(Element_MouseOver);
            webBrowser.PreviewKeyDown += new PreviewKeyDownEventHandler(Control_KeyDown);

            //All links in this document navigate to self window
            foreach (HtmlElement archor in this.webBrowser.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }
            //All forms in this document navigate to self window
            foreach (HtmlElement form in this.webBrowser.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
        }

        private void Control_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.ToString() == "17")
            {
                webBrowser.Hide();
                webSite.Focus();
            }
        }
        private void navigate_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(webSite.Text);
        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        /// <summary>
        /// This function handle element in the document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Element_MouseOver(object sender, HtmlElementEventArgs e)
        {
            webBrowser.Focus();
            var element = webBrowser.Document.GetElementFromPoint(e.ClientMousePosition);

            //Go to frame if the current element is frame
            if (element.TagName.ToLower().IndexOf("frame") != -1)
            {
                frameName = element.Name;
                frameId = element.Id;
                if (frameName != "")
                {
                    setFrameByName(frameName);
                }
                else if (frameId != "")
                {
                    setFrameById(frameId);
                }
                else
                {
                    setFrame(element.OuterHtml);
                }
                {
                    if (checkFrame.Checked == true)
                    {
                        frame.MouseOver += new HtmlElementEventHandler(Frame_MouseOver);
                    }
                }
            }
            setLocatorValue(element);
        }

        /// <summary>
        /// This function handle element in frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Frame_MouseOver(object sender, HtmlElementEventArgs e)
        {
            var element = frame.GetElementFromPoint(e.ClientMousePosition);
            try
            {
                //Go to frame if the current element is frame
                if (element.TagName.ToLower().IndexOf("frame") != -1)
                {
                    frameName = element.Name;
                    frameId = element.Id;
                    if (frameName != "")
                    {
                        setFrameByName(frameName);
                    }
                    else if (frameId != "")
                    {
                        setFrameById(frameId);
                    }
                    else
                    {
                        setFrame(element.OuterHtml);
                    }
                    if (checkFrame.Checked == true)
                    {
                        frame.MouseOver += new HtmlElementEventHandler(Frame_MouseOver);
                    }
                }
                setLocatorValue(element);
            }
            catch
            {

            }
        }

        void setFrameByName(String frameName)
        {
            for (int i = 0; i < webBrowser.Document.Window.Frames.Count; i++)
            {
                if (webBrowser.Document.Window.Frames[i].WindowFrameElement.Name == frameName)
                {
                    frame = webBrowser.Document.Window.Frames[i].Document;
                }
            }
        }

        void setFrameById(String frameId)
        {
            for (int i = 0; i < webBrowser.Document.Window.Frames.Count; i++)
            {
                if (webBrowser.Document.Window.Frames[i].WindowFrameElement.Id == frameId)
                {
                    frame = webBrowser.Document.Window.Frames[i].Document;
                }
            }
        }

        void setFrame(String outerHtml)
        {
            for (int i = 0; i < webBrowser.Document.Window.Frames.Count; i++)
            {
                if (webBrowser.Document.Window.Frames[i].WindowFrameElement.OuterHtml == outerHtml)
                {
                    frame = webBrowser.Document.Window.Frames[i].Document;
                }
            }
        }

        private void setLocatorValue(HtmlElement element)
        {
            cssPathLocator.Text = getCssPath(element);
            cssSubPathLocator.Text = getCssSubPath(element);
            idLocator.Text = element.Id;
            linkTextLocator.Text = getLinkText(element);
            tagNameLocator.Text = element.TagName;
            frameIdLocator.Text = frameId;
            frameNameLocator.Text = frameName;
            xpathAbsoluteLocator.Text = getXpath(element, true);
            xpathRelativeLocator.Text = getXpath(element, false);
        }

        string getLinkText(HtmlElement element)
        {
            string linkText = "";
            if (element.TagName.ToLower() == "a")
            {
                linkText = element.InnerText;
            }
            return linkText;
        }

        string getElementName(HtmlElement element)
        {
            string elementName;
            string htmlStr = element.OuterHtml;
            int tagPosition = htmlStr.IndexOf("name=");
            if (tagPosition != -1)
            {
                elementName = element.GetAttribute("name");
            }
            else
            {
                elementName = "";
            }
            return elementName;
        }

        /// <summary>
        /// Get CSS absolute path
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string getCssPath(HtmlElement element)
        {
            string subpath = getCssSubPath(element);
            while (element.TagName.ToLower() != "html")
            {
                subpath = getCssSubPath(element.Parent) + " > " + subpath;
                element = element.Parent;
            }
            return subpath;
        }

        /// <summary>
        /// Get CSS of the current element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string getCssSubPath(HtmlElement element)
        {
            string[] cssAttributes = new string[] { "id", "name", "class", "type", "alt", "title", "value" };
            string subPath = "";
            try
            {
                foreach (string attr in cssAttributes)
                {
                    var attrValue = element.GetAttribute(attr);

                    if (attrValue != "")
                    {
                        if (attr == "id")
                        {
                            subPath = "#" + attrValue;
                            goto exitFunction;
                        }
                        else if (attr == "class")
                        {
                            subPath = element.TagName.ToLower() + "." + attrValue.Replace(" ", ".").Replace("..", ".");
                            goto exitFunction;
                        }
                        else
                        {
                            subPath = element.TagName.ToLower() + "[" + attr + "= '" + attrValue + "']";
                        }
                    }
                }
            }
            catch
            {

            }

            if (getPreviousSiblingNodeNumber(element) > 1)
            {
                subPath = element.TagName.ToLower() + ":nth-of-type(" + getPreviousSiblingNodeNumber(element) + ")";
            }
            else if(getNextSiblingNodeNumber(element) > 1)
            {
                subPath = element.TagName.ToLower() + ":nth-of-type(1)";
            }
            else
            {
                subPath = element.TagName.ToLower();
            }

        exitFunction:
            return subPath;
        }

        int getPreviousSiblingNodeNumber(HtmlElement element)
        {
            int nodeNumber = 1;
            mshtml.IHTMLDOMNode domNode = (mshtml.IHTMLDOMNode)element.DomElement;
            mshtml.IHTMLDOMNode previousNode = domNode.previousSibling;
            while (previousNode != null)
            {
                if (previousNode.nodeName == element.TagName)
                {
                    nodeNumber = nodeNumber + 1;
                }
                previousNode = previousNode.previousSibling;
            }
            return nodeNumber;
        }

        int getNextSiblingNodeNumber(HtmlElement element)
        {
            int nodeNumber = 0;
            mshtml.IHTMLDOMNode domNode = (mshtml.IHTMLDOMNode)element.DomElement;
            mshtml.IHTMLDOMNode previousNode = domNode.nextSibling;
            while (previousNode != null)
            {
                if (previousNode.nodeName == element.TagName)
                {
                    nodeNumber = nodeNumber + 1;
                }
                previousNode = previousNode.nextSibling;
            }
            return nodeNumber;
        }

        string getXpath(HtmlElement element, Boolean absolute)
        {
            ArrayList nodes = new ArrayList();
            string xpath;
            int i = -1;
            bool isBreak = false;
            string currentNode;

            if (element == null)
            {
                xpath = "";
            }

            while (element != null)
            {
                i = i + 1;
                currentNode = getNode(element, absolute);

                if (currentNode != null)
                {
                    nodes.Add(currentNode);
                    if (currentNode.IndexOf("@id") > 0 || currentNode.IndexOf("@name") > 0)
                    {
                        isBreak = true;
                    }
                }

                if (isBreak == false)
                {
                    element = element.Parent;
                }
                else
                {
                    element = null;
                }
            }
            string resultPath;
            resultPath = joininReverse(nodes, "/", i);
            if (absolute == false)
            {
                if (resultPath.IndexOf("html") > 0)
                {
                    xpath = joininReverse(nodes, "/", i);
                }
                else
                {
                    xpath = "/" + joininReverse(nodes, "/", i);
                }

            }
            else
            {
                xpath = joininReverse(nodes, "/", i);
            }

            return xpath;
        }

        string getNode(HtmlElement element, Boolean absolute)
        {
            string nodeExpr;
            bool isContinue;

            nodeExpr = element.TagName.ToLower();
            isContinue = true;

            //Handle xpath relative path
            if (absolute == false)
            {
                string elementName = getElementName(element);
                if (element.Id != null)
                {
                    nodeExpr = nodeExpr + "[@id='" + element.Id + "']";
                    isContinue = false;
                }
                else if (elementName != "")
                {
                    nodeExpr = nodeExpr + "[@name='" + elementName + "']";
                    isContinue = false;
                }
            }

            //Handle xpath absolute path
            if (isContinue)
            {
                int rank = 1;
                mshtml.IHTMLDOMNode domNode = (mshtml.IHTMLDOMNode)element.DomElement;
                mshtml.IHTMLDOMNode previousNode = domNode.previousSibling;

                while (previousNode != null)//Get the sibling node number of the current node
                {
                    if (previousNode.nodeName == element.TagName)
                    {
                        rank = rank + 1;
                    }
                    previousNode = previousNode.previousSibling;
                }
                if (rank > 1)//Generate node express: e.g., div[3]
                {
                    nodeExpr = nodeExpr + "[" + rank.ToString() + "]";
                }
                else
                {
                    mshtml.IHTMLDOMNode nextNode = domNode.nextSibling;
                    while (nextNode != null)
                    {
                        if (nextNode.nodeName == element.TagName)
                        {
                            nodeExpr = nodeExpr + "[1]";
                            break;
                        }
                        else
                        {
                            nextNode = nextNode.nextSibling;
                        }
                    }

                }
            }
            return nodeExpr;
        }

        private void objectSpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "16")
            {
                webBrowser.Show();
                webBrowser.Focus();
            }
        }

        private void checkFrame_CheckedChanged(object sender, EventArgs e)
        {
            if(checkFrame.Checked == false)
            {
                webBrowser.Refresh();
            }
        }

        string joininReverse(ArrayList arrayList, string delimiter, int totalSiblingCount)
        {
            string actXpath = "";
            for (int siblingPosition = 0; siblingPosition <= totalSiblingCount; siblingPosition++)
            {
                if (arrayList != null)
                {
                    actXpath = actXpath + delimiter + arrayList[totalSiblingCount - siblingPosition];
                }
            }
            return actXpath;
        }
    }
}
