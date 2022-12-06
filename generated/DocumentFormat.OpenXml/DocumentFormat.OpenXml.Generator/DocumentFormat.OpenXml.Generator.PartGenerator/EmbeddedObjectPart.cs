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
    /// Defines the EmbeddedObjectPart
    /// </summary>
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class EmbeddedObjectPart : TypedOpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject";

        /// <summary>
        /// Creates an instance of the EmbeddedObjectPart OpenXmlType
        /// </summary>
        internal protected EmbeddedObjectPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : PartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Extension => ".bin";
            string ITargetFeature.Name => "embeddedObject";
            string ITargetFeature.Path => "embeddings";
        }
    
    }
}
