using LiveVedioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveVedioAdmin
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnForbid_Click(object sender, EventArgs e)
        {
            string userID = TxtUserID.Text.Trim();
            int time = int.Parse(TxtTime.Text.Trim());
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            LblMessage.Text = liveVedio.Forbid(userID, time);
        }

        protected void BtnResume_Click(object sender, EventArgs e)
        {
            string userID = TxtUserID.Text.Trim();
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            LblMessage.Text = liveVedio.Resume(userID);
        }

        protected void BtnPublishList_Click(object sender, EventArgs e)
        {
            string userID = TxtUserID.Text.Trim();
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            LblMessage.Text = liveVedio.GetPublishList(userID, DateTime.Now.AddDays(-30), DateTime.Now);
        }

        protected void BtnOnlineList_Click(object sender, EventArgs e)
        {
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            var list = liveVedio.GetOnlineList();
            if(list.Count >0)
            {
                StringBuilder sb = new StringBuilder();
                foreach(var item in list)
                {
                    sb.AppendLine("rtmp://" + item.DomainName + "/" + item.AppName + "/" + item.StreamName);
                }
                LblMessage.Text = sb.ToString();
            }
        }

        protected void BtnGetTotalUserNum_Click(object sender, EventArgs e)
        {
            string userID = TxtUserID.Text.Trim();
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            LblMessage.Text = liveVedio.GetTotalUserNumber(userID).ToString();
        }
    }
}