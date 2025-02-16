﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using Telerik Data Access template.
// Code is generated on: 3/3/2019 8:16:36 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace VRGameSelectorServerDB
{
    public partial class VRArcadeDataAccessModelMetadataSource
    {
        public MappingConfiguration<VRManageLog> GetVRManageLogMappingConfiguration()
        {
            MappingConfiguration<VRManageLog> configuration = this.GetVRManageLogClassConfiguration();
            this.PrepareVRManageLogConfigurations(configuration);
            this.OnPrepareVRManageLogConfigurations(configuration);
            return configuration;
        }

        public MappingConfiguration<VRManageLog> GetVRManageLogClassConfiguration()
        {
            MappingConfiguration<VRManageLog> configuration = new MappingConfiguration<VRManageLog>();
            configuration.MapType(x => new { }).ToTable("VRManageLogs");
            return configuration;
        }
	
        public void PrepareVRManageLogConfigurations(MappingConfiguration<VRManageLog> configuration)
        {
            configuration.HasProperty(x => x.ID).ToColumn(@"ID").IsIdentity(KeyGenerator.Autoinc).WithOpenAccessType(OpenAccessType.Int32).IsNotNullable();
            configuration.HasProperty(x => x.Operation).ToColumn(@"Operation").WithOpenAccessType(OpenAccessType.Varchar).IsNotNullable().HasLength(255).IsUnicode();
            configuration.HasProperty(x => x.AdditonalInfo).ToColumn(@"AdditonalInfo").WithOpenAccessType(OpenAccessType.Varchar).IsNullable().HasLength(255).IsUnicode();
            configuration.HasProperty(x => x.Source).ToColumn(@"Source").WithOpenAccessType(OpenAccessType.Varchar).IsNotNullable().HasLength(255).IsUnicode();
            configuration.HasProperty(x => x.SourceIdentity).ToColumn(@"SourceIdentity").WithOpenAccessType(OpenAccessType.Varchar).IsNotNullable().HasLength(255).IsUnicode();
            configuration.HasProperty(x => x.TimeStamp).ToColumn(@"TimeStamp").WithOpenAccessType(OpenAccessType.DateTime).IsNotNullable();
            configuration.HasProperty(x => x.VRClientID).ToColumn(@"VRClientID").WithOpenAccessType(OpenAccessType.Int32).IsNullable().HasPrecision(11);
            configuration.HasProperty(x => x.VRTileconfigID).ToColumn(@"VRTileconfigID").WithOpenAccessType(OpenAccessType.Int32).IsNullable().HasPrecision(11);
            configuration.HasProperty(x => x.VRTicketGUID).ToColumn(@"VRTicketGUID").WithOpenAccessType(OpenAccessType.Varchar).IsNullable().HasLength(36).IsUnicode();
            configuration.HasAssociation<VRClient>(x => x.VRClient).WithOpposite(op => op.VRManageLogs).HasConstraint((x, y) =>  x.VRClientID == y.ID);
            configuration.HasAssociation<VRTileconfig>(x => x.VRTileconfig).WithOpposite(op => op.VRManageLogs).HasConstraint((x, y) =>  x.VRTileconfigID == y.ID);
            configuration.HasAssociation<VRTicket>(x => x.VRTicket).WithOpposite(op => op.VRManageLogs).HasConstraint((x, y) =>  x.VRTicketGUID == y.GUID);
        }

        partial void OnPrepareVRManageLogConfigurations(MappingConfiguration<VRManageLog> configuration);
    }
}
