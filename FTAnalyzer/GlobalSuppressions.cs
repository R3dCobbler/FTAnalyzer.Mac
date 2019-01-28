﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "Crash avoidance", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.SetRootIndividual(System.Xml.XmlDocument)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0165:Asynchronous methods should return a Task instead of void", Justification = "Contract for caller", Scope = "member", Target = "~M:FTAnalyzer.AppDelegate.CheckWebVersion")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.GetNotes(System.Xml.XmlNode)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.ExportReferrals.ShortCode")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.ExportReferrals.FTAnalyzer#IExportReferrals#RelationType")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.LostCousinsReferralComparer.Compare(FTAnalyzer.ExportReferrals,FTAnalyzer.ExportReferrals)~System.Int32")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.CensusAgeComparer.Compare(FTAnalyzer.CensusIndividual,FTAnalyzer.CensusIndividual)~System.Int32")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Age.#ctor(FTAnalyzer.Individual,FTAnalyzer.FactDate)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.CensusFamily.IsValidIndividual(FTAnalyzer.CensusIndividual,System.Boolean,System.Boolean,System.Boolean)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.op_Equality(FTAnalyzer.FactDate,FTAnalyzer.FactDate)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancies in Symbol Declarations", "RECS0122:Initializing field with default value is redundant", Justification = "<Pending>", Scope = "member", Target = "~F:FTAnalyzer.FactDate.MINYEARS")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancies in Symbol Declarations", "RECS0122:Initializing field with default value is redundant", Justification = "<Pending>", Scope = "member", Target = "~F:FTAnalyzer.FactDate.LOW")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.BetweenFixes(System.String)~System.Tuple{System.Boolean,System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.IsValidDoubleDate(System.String,System.String,System.Text.RegularExpressions.Group)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.StartsBefore(FTAnalyzer.FactDate)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.EndsAfter(FTAnalyzer.FactDate)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.FactDate.BestYear")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.CompareTo(FTAnalyzer.FactDate)~System.Int32")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactDate.ToString~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.GetText(System.Xml.XmlNode,System.Boolean)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.CheckLooseBirth(FTAnalyzer.Individual,FTAnalyzer.Utilities.SortableBindingList{FTAnalyzer.IDisplayLooseBirth})")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.BaseLivingDate(FTAnalyzer.Individual)~FTAnalyzer.FactDate")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.CheckLooseDeath(FTAnalyzer.Individual,FTAnalyzer.Utilities.SortableBindingList{FTAnalyzer.IDisplayLooseDeath})")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.BuildFindMyPastQuery(System.String,System.Int32,FTAnalyzer.Individual)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.BuildFindMyPastQuery(FTAnalyzer.FamilyTree.SearchType,FTAnalyzer.Individual,FTAnalyzer.FactDate)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.FixIndividualID(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.IsMarried(FTAnalyzer.FactDate)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.QuestionGender(FTAnalyzer.Family,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.AliveOnAnyCensus(System.String)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.OutOfCountryOnAllCensus(System.String)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.Individual.BaptChri")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.Individual.Death")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~P:FTAnalyzer.Individual.CremBuri")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Individual.MarriageString(System.Int32)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:System.Web.HttpUtility.HexToInt(System.Char)~System.Int32")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactLocation.CensusCountryMatches(System.String,System.Boolean)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactLocation.op_Equality(FTAnalyzer.FactLocation,FTAnalyzer.FactLocation)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.LoadStandardisedNames(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.ColourCensus(System.String,FTAnalyzer.ViewControllers.RelationTypes,System.String,FTAnalyzer.ComboBoxFamily,System.Boolean,System.Boolean)~System.Collections.Generic.List{FTAnalyzer.IDisplayColourCensus}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.SerializeNonDuplicates")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancies in Symbol Declarations", "RECS0154:Parameter is never used", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.ViewControllers.ColourCensusViewController.#ctor(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0045:Convert to conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.ViewControllers.ColourCensusViewController.ViewDetailsSelector")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0018:Comparison of floating point numbers with equality operator", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactLocation.IsGeoCoded(System.Boolean)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0018:Comparison of floating point numbers with equality operator", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactLocation.GecodingMatches(FTAnalyzer.FactLocation)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0018:Comparison of floating point numbers with equality operator", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactLocation.#ctor(System.String,System.String,System.String,FTAnalyzer.FactLocation.Geocode)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FactSource.FixSourceID(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Statistics.DisplayGOONSpage(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Language Usage Opportunities", "RECS0002:Convert anonymous method to method group", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.ColourBMD(FTAnalyzer.ViewControllers.RelationTypes,System.String,FTAnalyzer.ComboBoxFamily)~System.Collections.Generic.List{FTAnalyzer.IDisplayColourBMD}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Language Usage Opportunities", "RECS0002:Convert anonymous method to method group", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.ColourCensus(System.String,FTAnalyzer.ViewControllers.RelationTypes,System.String,FTAnalyzer.ComboBoxFamily,System.Boolean,System.Boolean)~System.Collections.Generic.List{FTAnalyzer.IDisplayColourCensus}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Language Usage Opportunities", "RECS0002:Convert anonymous method to method group", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.FamilyTree.MissingData(FTAnalyzer.ViewControllers.RelationTypes,System.String,FTAnalyzer.ComboBoxFamily)~System.Collections.Generic.List{FTAnalyzer.IDisplayMissingData}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Code Notifications", "XI0002:Notifies you from using newer Apple APIs when targeting an older OS version", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.ViewControllers.TablePrintingViewController`1.SetupPrintView~AppKit.NSTableView")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Code Notifications", "XI0002:Notifies you from using newer Apple APIs when targeting an older OS version", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.ViewControllers.BindingListViewController`1.SetupTableView~AppKit.NSScrollView")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0165:Asynchronous methods should return a Task instead of void", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.GedcomDocument.ReadFromUrl(Foundation.NSUrl,System.String,Foundation.NSError@)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Code Notifications", "XI0002:Notifies you from using newer Apple APIs when targeting an older OS version", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.ViewControllers.TablePrintingViewController.SetupView~AppKit.NSScrollView")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "<Pending>", Scope = "member", Target = "~M:FTAnalyzer.Utilities.DatabaseHelper.Dispose(System.Boolean)")]

