/*==========================================================================;
 *
 *  This file is part of LATINO. See http://latino.sf.net
 *
 *  File:    TextBlock.cs
 *  Desc:    Annotated text block data structure
 *  Created: Nov-2010
 *
 *  Authors: Miha Grcar
 *
 ***************************************************************************/

using System;
using System.Collections.Generic;

namespace Latino.Workflows.TextMining
{
    /* .-----------------------------------------------------------------------
       |
       |  Class TextBlock
       |
       '-----------------------------------------------------------------------
    */
    public class TextBlock
    {        
        private int mSpanStart;
        private int mSpanEnd;
        private string mType;
        private string mText;
        private Dictionary<string, string> mFeatures
            = new Dictionary<string, string>();

        internal TextBlock(int spanStart, int spanEnd, string type, string text, Dictionary<string, string> features)
        {
            mSpanStart = spanStart;
            mSpanEnd = spanEnd;
            mType = type;
            mText = text;
            mFeatures = features;
        }

        public int SpanStart
        {
            get { return mSpanStart; }
        }

        public int SpanEnd
        {
            get { return mSpanEnd; }
        }

        public string Type
        {
            get { return mType; }
        }

        public string Text
        {
            get { return mText; }
        }

        public Dictionary<string, string>.KeyCollection Features
        {
            get { return mFeatures.Keys; }
        }

        public string GetFeatureValue(string name)
        {
            Utils.ThrowException(name == null ? new ArgumentNullException("name") : null);
            string value;
            if (mFeatures.TryGetValue(name, out value))
            {
                return value;
            }
            return null;
        }
    }
}
