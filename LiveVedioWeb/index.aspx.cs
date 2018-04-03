using LiveVedioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveVedioWeb
{
    public partial class _Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {

            Response.Redirect("livePlay.aspx?url=" + TxtOnlineVedio.Text);
        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            TxtOnlineVedio.Text = GetAuthkey("livefor1yyg", "aaa", "1001");
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            var list = liveVedio.GetOnlineList();
            if (list.Count > 0)
            {
                string authKey = GetAuthkey( "livefor1yyg", list[0].AppName, list[0].StreamName );
                TxtOnlineVedio.Text = string.Format("rtmp://{0}/{1}/{2}?auth_key={3}", list[0].DomainName, list[0].AppName, list[0].StreamName, authKey);
            }
        }

        private string GetAuthkey(string secret, string appName, string streamName)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            long timeStamp = (long)(DateTime.Now.AddDays(1) - startTime).TotalMilliseconds / 1000; // 相差毫秒数
            //timeStamp = 1492144207;
            string strpush = "/" + appName + "/" + streamName + "-" + timeStamp.ToString() + "-0-0-" + secret;
            //string lowMd5 = MD5(strpush).ToLower();
            return timeStamp + "-0-0-" + MD5(strpush).ToLower();
        }
        private string MD5(string encryptString)
        {
            byte[] result = Encoding.Default.GetBytes(encryptString);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string encryptResult = BitConverter.ToString(output).Replace("-", "");
            return encryptResult;
        }

        protected void btnLinqToJson_Click( object sender, EventArgs e )
        {
            
        }
    }
}