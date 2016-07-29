using System.Text;
using System;
using System.Collections.Generic;
using System.IO;

namespace Core
{
    /// <summary>
    /// 投稿に使う各種キーの集まり。（型定義）
    /// </summary>
    public class Keys
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string AccessToken { get; set; }
        public string AccessSecret { get; set; }
    }

}