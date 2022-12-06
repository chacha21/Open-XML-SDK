﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the RdSupportingPropertyBagStructurePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class RdSupportingPropertyBagStructurePart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.rdsupportingpropertybagstructure+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/rdSupportingPropertyBagStructure";
        private DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructures? _rootElement;

        /// <summary>
        /// Creates an instance of the RdSupportingPropertyBagStructurePart OpenXmlType
        /// </summary>
        internal protected RdSupportingPropertyBagStructurePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructures;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => SupportingPropertyBagStructures;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructures SupportingPropertyBagStructures
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructures>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : PartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "rdsupportingpropertybagstructure";
            string ITargetFeature.Path => "richData";
        }
    
    }
}
