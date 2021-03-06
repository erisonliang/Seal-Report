﻿//
// Copyright (c) Seal Report, Eric Pfirsch (sealreport@gmail.com), http://www.sealreport.org.
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. http://www.apache.org/licenses/LICENSE-2.0..
//
using Seal.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Seal.Converter
{
    public class WidgetIconClassConverter : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true; //true means show a combobox
        }
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false; //true will limit to list. false will show the list, but allow free-form entry
        }


        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var icons = new List<string>();
            foreach (var icon in Dashboard.Icons) icons.Add("glyphicon glyphicon-" + icon);
            return new StandardValuesCollection(icons);
        }
    }

}
