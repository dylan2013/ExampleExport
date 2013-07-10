using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA.DSAUtil;
using Framework.Feature;
using System.Xml;
using SHSchool.Data;
using Campus.DocumentValidator;

namespace ExportExample
{
    static public class GetConfig
    {
        /// <summary>
        /// 取得文字評量代碼表清單
        /// </summary>
        static public List<string> GetWordCommentList()
        {
            List<string> faceList = new List<string>();
            DSXmlHelper helper = Config.GetWordCommentList().GetContent();
            foreach (XmlElement morality in helper.GetElements("Content/Morality"))
            {
                DSXmlHelper moralityHelper = new DSXmlHelper(morality);
                string face = moralityHelper.GetText("@Face");
                if (!faceList.Contains(face))
                {
                    faceList.Add(face);
                }
            }
            return faceList;
        }
    }
}
