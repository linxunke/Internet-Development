using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Translator.App_Code
{
    public class TranslatorClass
    {
        string mstrText, mstrOriginal;
        const string HM = "hey mate!";
        public string Text
        {
            get
            {
                return mstrText;
            }
            set
            {
                mstrText = value;
                mstrOriginal = value;
            }
        }
        public void Restore()
        {
            mstrText = mstrOriginal;
        }
        public void Translate()
        {
            string strWord;
            string[] arrWords;
            bool bCaps = false;
            arrWords = mstrText.Split(' ');
            for (int intCount = 0; intCount <= arrWords.GetUpperBound(0);
                intCount++)
            {
                strWord = arrWords[intCount].ToLower();
                if (!arrWords[intCount].Equals(strWord)) bCaps = ture;
                if (strWord != "")
                {
                    strWord = strWord.Substring(1, strWord.Length - 1) +
                        strWord.Substring(0, 1) + HM;
                    if (bCaps) strWord = strWord.Substring(0, 1).ToUpper() +
                          strWord.Substring(1, strWord.Length - 1);
                }
                arrWords[intCount] = strWord;
                bCaps = false;
            }
            mstrText = String.Join(" ", arrWords);
        }
    }
}