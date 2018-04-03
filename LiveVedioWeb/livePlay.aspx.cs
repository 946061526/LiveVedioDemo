using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveVedioWeb
{
    public partial class _LivePlay : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hidUrl.Value = Request["url"];
            hidUrl.Value = "rtmp://imlive.1yyg.com/1yyg/LiveStream242983?auth_key=1495009033-0-0-270a76ec6bf611482d4db9bacced6845";
            //hidUrl.Value = "rtmp://imlive.1yyg.com/1yyg/teststream1?auth_key=1492148104-0-0-f923fcc4380079c278c7d0bbcd5725c3";
         //  hidUrl.Value = "rtmp://imlive.1yyg.com/1yyg/teststream1?auth_key=1492141513-0-0-d56d96ac8dae3ff63129990b24286236";
            //http://localhost:12585/livePlay.aspx?url=rtmp://imlive.1yyg.com/1yyg/teststream1?auth_key=1492142112-0-0-4de79b757bca74ea11283020bf213dd5
        }

    }
}