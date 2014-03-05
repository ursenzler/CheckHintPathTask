// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XmlExtensions.cs" company="Appccelerate">
//   Copyright (c) 2008-2014
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Appccelerate.CheckHintPathTask
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public static class XmlExtensions
    {
        public static string GetHintPath(this XElement reference)
        {
            XNamespace ns = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");

            XElement hintPath = reference.Element(ns + "HintPath");

            return hintPath != null ? hintPath.Value : null;
        }

        public static string GetAttributeValue(this XElement element, string name)
        {
            var attribute = element.Attributes().SingleOrDefault(
                a => a.Name.LocalName.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            return attribute != null ? attribute.Value : null;
        }
    }
}