using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using System.Security.Cryptography.X509Certificates;
using CefSharp.Handler;

namespace UP主抓包神器
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initCefBrowser();
        }
        MyRequestHandler mRequestHandler;
        ChromiumWebBrowser mWebBrowser;
        CefSharp.IBrowser mIBrowser;
        CefSharp.IWebBrowser mIWebBrowser;
        private void initCefBrowser() {

            filterHosts = txtFilterHost.Text.Split(',');
            CefSettings settings = new CefSettings();
            settings.IgnoreCertificateErrors = true;
            settings.AcceptLanguageList = "zh,zh-CN;q=0.9";
            settings.UserAgent = "Mozilla/5.0 (Linux; Android 9; PH-1 Build/PPR1.180610.091; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/66.0.3359.126 MQQBrowser/6.2 TBS/044807 Mobile Safari/537.36 V1_AND_SQ_8.0.8_1218_YYB_D QQ/8.0.8.4115 NetType/WIFI WebP/0.3.0 Pixel/1312 StatusBarHeight/151";
            CefSharp.Cef.Initialize(settings);
            mWebBrowser = new ChromiumWebBrowser("http://cn.bing.com/");
            browserPanel.Controls.Add(mWebBrowser);
            mWebBrowser.Dock = DockStyle.Fill;
            mWebBrowser.TitleChanged += MWebBrowser_TitleChanged;
            mWebBrowser.LoadingStateChanged += MIBrowser_LoadingStateChanged;
            mWebBrowser.AddressChanged += MWebBrowser_AddressChanged;
            mRequestHandler = new MyRequestHandler(this);
            mWebBrowser.RequestHandler = mRequestHandler;
            mRequestHandler.OnCaptureResult += MRequestHandler_OnCaptureResult;
            mWebBrowser.FrameLoadStart += MWebBrowser_FrameLoadStart;
        }

        private void MRequestHandler_OnCaptureResult(object sender, CaputreEventArgs e)
        {
            Console.WriteLine(e.domain);
            if (!chkUsesCapture.Checked) { return; }
            foreach (string host in filterHosts) {
                if (e.domain.Trim().EndsWith(host.Trim())) {
                    return;
                }
            }
            listPost.Items.Add(e.content);
        }

        private void MWebBrowser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            try
            {
                mIBrowser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
            }
            catch { }
        }

        private void MWebBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            try
            {
                mIBrowser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
            }
            catch { }
            if (null == addressChangeMethod) { addressChangeMethod = new OnTitleChanged(onAddressChanged); }
            lblTitle.Invoke(addressChangeMethod, e.Address);
        }

        private void MIBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (null == mIBrowser)
            {
                mIBrowser = e.Browser;
            }
            mIBrowser.SetZoomLevel(0.1);
            if (null == loadStateChangeMethod) { loadStateChangeMethod = new OnLoadStateChanged(onLoadStateChanged); }
            progressBar.Invoke(loadStateChangeMethod, e.IsLoading);
            
        }
        private void MWebBrowser_TitleChanged(object sender, CefSharp.TitleChangedEventArgs e)
        {
            if (null == titleChangeMethod) { titleChangeMethod = new OnTitleChanged(onTitleChanged); }
            lblTitle.Invoke(titleChangeMethod, e.Title);
        }

        delegate void OnTitleChanged(string title);
        OnTitleChanged titleChangeMethod;
        void onTitleChanged(string title) {
            lblTitle.Text = title;
        }
        OnTitleChanged addressChangeMethod;
        void onAddressChanged(string address) {
            txtCurrentAddress.Text = address;
            if (chkUsesCapture.Checked) {
                txtAddressRecord.AppendText(address);
                txtAddressRecord.AppendText("\r\n");
            }
        }
        delegate void OnLoadStateChanged(bool loading);
        OnLoadStateChanged loadStateChangeMethod;
        void onLoadStateChanged(bool loading)
        {
            progressBar.Style = loading ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            btnBack.Enabled = mIBrowser.CanGoBack;
            btnForward.Enabled = mIBrowser.CanGoForward;
            btnRefresh.Enabled = !mIBrowser.IsLoading;
            btnStop.Enabled = mIBrowser.IsLoading;
        }
        #region UI Function

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mWebBrowser.Visible = !mWebBrowser.Visible;
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            mWebBrowser.Load(txtUrl.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mIBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            mIBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mIBrowser.Reload();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mIBrowser.StopLoad();
        }

        private void btnDevTools_Click(object sender, EventArgs e)
        {
            mIBrowser.ShowDevTools();
        }
        
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (txtUrl.Text.Contains("\n")) {
                txtUrl.Text = txtUrl.Text.Replace("\n", "").Replace("\r", "");
                btnGoto_Click(sender, e);
            }
        }
        #endregion
        class MyLoadHandler : ILoadHandler
        {
            void ILoadHandler.OnFrameLoadEnd(IWebBrowser chromiumWebBrowser, FrameLoadEndEventArgs frameLoadEndArgs)
            {
                try
                {
                    chromiumWebBrowser.GetMainFrame().Browser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
                }
                catch { }
            }

            void ILoadHandler.OnFrameLoadStart(IWebBrowser chromiumWebBrowser, FrameLoadStartEventArgs frameLoadStartArgs)
            {
                try
                {
                    chromiumWebBrowser.GetMainFrame().Browser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
                }
                catch { }
            }

            void ILoadHandler.OnLoadError(IWebBrowser chromiumWebBrowser, LoadErrorEventArgs loadErrorArgs)
            {
                try
                {
                    chromiumWebBrowser.GetMainFrame().Browser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
                }
                catch { }
            }

            void ILoadHandler.OnLoadingStateChange(IWebBrowser chromiumWebBrowser, LoadingStateChangedEventArgs loadingStateChangedArgs)
            {
                try
                {
                    chromiumWebBrowser.GetMainFrame().Browser.MainFrame.EvaluateScriptAsync("Object.defineProperty(this,'navigator',{value :{platform :\"Android\"}});");
                }
                catch { }
            }
        }

        public class MyRequestHandler : DefaultRequestHandler
        {
            public event EventHandler<CaputreEventArgs> OnCaptureResult;
            Control mInvoker;
            public MyRequestHandler(Control invoker) {
                mInvoker = invoker;
            }

            public override CefReturnValue OnBeforeResourceLoad(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
            {
                processRequest(request, null);
                return base.OnBeforeResourceLoad(browserControl, browser, frame, request, callback);
            }
            
            public void processRequest(IRequest request,IResponse response) {
                StringBuilder sbuidler = new StringBuilder();
                if (request.Method == "POST")
                {
                    sbuidler.Append("POST ").Append(request.Url).AppendLine().Append(" Post Data:").AppendLine();
                    foreach (IPostDataElement elm in request.PostData.Elements) {
                        if (elm.Type != PostDataElementType.File) {
                            sbuidler.Append(elm.GetBody()).AppendLine();
                        }
                    }
                    CaputreEventArgs captures = new CaputreEventArgs();
                    captures.content = sbuidler.ToString();
                    captures.domain = getDomain(request.Url);

                    if (null != OnCaptureResult) {
                        mInvoker.Invoke(OnCaptureResult, request, captures);
                    }
                }
                else if (request.Method == "GET" && request.Url.Contains('?') && request.Url.Contains('='))
                {
                    sbuidler.Append("GET  ").Append(request.Url);
                    CaputreEventArgs captures = new CaputreEventArgs();
                    captures.content = sbuidler.ToString();
                    captures.domain = getDomain(request.Url);
                    if (null != OnCaptureResult)
                    {
                        mInvoker.Invoke(OnCaptureResult, request, captures);
                    }
                }
            }

            private string getDomain(String url) {
                if (url.Contains("://")) {
                    string[] host1 = url.Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
                    if (host1.Length > 1) {
                        string[] domain1 = host1[1].Split('/');
                        return domain1[0];
                    }
                }
                return "";
            }
        }

        public class CaputreEventArgs : EventArgs {
            public string domain;
            public string content;
        }

        string[] filterHosts;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterHosts = txtFilterHost.Text.Split(',');
        }

        private void btnClearPost_Click(object sender, EventArgs e)
        {
            listPost.Items.Clear();
        }

        private void listPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPostDetail.Text = listPost.SelectedItem?.ToString();
        }
    }
}
