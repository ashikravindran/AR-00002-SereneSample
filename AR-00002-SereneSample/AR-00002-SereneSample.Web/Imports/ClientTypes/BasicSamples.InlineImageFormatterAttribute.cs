using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AR_00002_SereneSample.BasicSamples
{
    public partial class InlineImageFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "AR_00002_SereneSample.BasicSamples.InlineImageFormatter";

        public InlineImageFormatterAttribute()
            : base(Key)
        {
        }

        public String FileProperty
        {
            get { return GetOption<String>("fileProperty"); }
            set { SetOption("fileProperty", value); }
        }

        public Boolean Thumb
        {
            get { return GetOption<Boolean>("thumb"); }
            set { SetOption("thumb", value); }
        }
    }
}

