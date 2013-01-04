//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.551
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Notice: Use of the service proxies that accompany this notice is subject to
//            the terms and conditions of the license agreement located at
//            http://go.microsoft.com/fwlink/?LinkID=202740
//            If you do not agree to these terms you may not use this content.
namespace Student_Assistant
{
    using System;
    using System.Collections.Generic;
    using System.Data.Services.Client;
    using System.Net;
    using System.IO;
    
    
    public partial class ExpandableSearchResult {
        
        private Guid _ID;
        
        private Int64? _WebTotal;
        
        private Int64? _WebOffset;
        
        private String _AlteredQuery;
        
        private String _AlterationOverrideQuery;
        
        private System.Collections.ObjectModel.Collection<WebResult> _Web;
        
        public Guid ID {
            get {
                return this._ID;
            }
            set {
                this._ID = value;
            }
        }
        
        public Int64? WebTotal {
            get {
                return this._WebTotal;
            }
            set {
                this._WebTotal = value;
            }
        }
        
        public Int64? WebOffset {
            get {
                return this._WebOffset;
            }
            set {
                this._WebOffset = value;
            }
        }
        
        public String AlteredQuery {
            get {
                return this._AlteredQuery;
            }
            set {
                this._AlteredQuery = value;
            }
        }
        
        public String AlterationOverrideQuery {
            get {
                return this._AlterationOverrideQuery;
            }
            set {
                this._AlterationOverrideQuery = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<WebResult> Web {
            get {
                return this._Web;
            }
            set {
                this._Web = value;
            }
        }
    }
    
    public partial class WebResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _Description;
        
        private String _DisplayUrl;
        
        private String _Url;
        
        public Guid ID {
            get {
                return this._ID;
            }
            set {
                this._ID = value;
            }
        }
        
        public String Title {
            get {
                return this._Title;
            }
            set {
                this._Title = value;
            }
        }
        
        public String Description {
            get {
                return this._Description;
            }
            set {
                this._Description = value;
            }
        }
        
        public String DisplayUrl {
            get {
                return this._DisplayUrl;
            }
            set {
                this._DisplayUrl = value;
            }
        }
        
        public String Url {
            get {
                return this._Url;
            }
            set {
                this._Url = value;
            }
        }
    }
    
    public partial class BingSearchContainer : System.Data.Services.Client.DataServiceContext {
        
        public BingSearchContainer(Uri serviceRoot) : 
                base(serviceRoot) {
        }
        
        /// <summary>
        /// </summary>
        /// <param name="Query">Bing search query Sample Values : xbox</param>
        /// <param name="Market">Market. Note: Not all Sources support all markets. Sample Values : en-US</param>
        /// <param name="Adult">Adult setting is used for filtering sexually explicit content Sample Values : Moderate</param>
        /// <param name="Latitude">Latitude Sample Values : 47.603450</param>
        /// <param name="Longitude">Longitude Sample Values : -122.329696</param>
        /// <param name="WebFileType">File extensions to return Sample Values : XLS</param>
        /// <param name="Options">Specifies options for this request for all Sources. Valid values are: DisableLocationDetection, EnableHighlighting. Sample Values : EnableHighlighting</param>
        /// <param name="WebSearchOptions">Specify options for a request to the Web SourceType. Valid values are: DisableHostCollapsing, DisableQueryAlterations. Sample Values : DisableQueryAlterations</param>
        public DataServiceQuery<WebResult> Web(String Query, String Market, String Adult, Double? Latitude, Double? Longitude, String WebFileType, String Options, String WebSearchOptions) {
            if ((Query == null)) {
                throw new System.ArgumentNullException("Query", "Query value cannot be null");
            }
            DataServiceQuery<WebResult> query;
            query = base.CreateQuery<WebResult>("Web");
            if ((Query != null)) {
                query = query.AddQueryOption("Query", string.Concat("\'", System.Uri.EscapeDataString(Query), "\'"));
            }
            if ((Market != null)) {
                query = query.AddQueryOption("Market", string.Concat("\'", System.Uri.EscapeDataString(Market), "\'"));
            }
            if ((Adult != null)) {
                query = query.AddQueryOption("Adult", string.Concat("\'", System.Uri.EscapeDataString(Adult), "\'"));
            }
            if (((Latitude != null) 
                        && (Latitude.HasValue == true))) {
                query = query.AddQueryOption("Latitude", Latitude.Value);
            }
            if (((Longitude != null) 
                        && (Longitude.HasValue == true))) {
                query = query.AddQueryOption("Longitude", Longitude.Value);
            }
            if ((WebFileType != null)) {
                query = query.AddQueryOption("WebFileType", string.Concat("\'", System.Uri.EscapeDataString(WebFileType), "\'"));
            }
            if ((Options != null)) {
                query = query.AddQueryOption("Options", string.Concat("\'", System.Uri.EscapeDataString(Options), "\'"));
            }
            if ((WebSearchOptions != null)) {
                query = query.AddQueryOption("WebSearchOptions", string.Concat("\'", System.Uri.EscapeDataString(WebSearchOptions), "\'"));
            }
            return query;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="Query">Bing search query Sample Values : xbox</param>
        /// <param name="Market">Market. Note: Not all Sources support all markets. Sample Values : en-US</param>
        /// <param name="Adult">Adult setting is used for filtering sexually explicit content Sample Values : Moderate</param>
        /// <param name="Latitude">Latitude Sample Values : 47.603450</param>
        /// <param name="Longitude">Longitude Sample Values : -122.329696</param>
        /// <param name="WebFileType">File extensions to return Sample Values : XLS</param>
        /// <param name="Options">Specifies options for this request for all Sources. Valid values are: DisableLocationDetection, EnableHighlighting. Sample Values : EnableHighlighting</param>
        /// <param name="WebSearchOptions">Specify options for a request to the Web SourceType. Valid values are: DisableHostCollapsing, DisableQueryAlterations. Sample Values : DisableQueryAlterations</param>
        public DataServiceQuery<ExpandableSearchResult> Composite(String Query, String Market, String Adult, Double? Latitude, Double? Longitude, String WebFileType, String Options, String WebSearchOptions) {
            if ((Query == null)) {
                throw new System.ArgumentNullException("Query", "Query value cannot be null");
            }
            DataServiceQuery<ExpandableSearchResult> query;
            query = base.CreateQuery<ExpandableSearchResult>("Composite");
            if ((Query != null)) {
                query = query.AddQueryOption("Query", string.Concat("\'", System.Uri.EscapeDataString(Query), "\'"));
            }
            if ((Market != null)) {
                query = query.AddQueryOption("Market", string.Concat("\'", System.Uri.EscapeDataString(Market), "\'"));
            }
            if ((Adult != null)) {
                query = query.AddQueryOption("Adult", string.Concat("\'", System.Uri.EscapeDataString(Adult), "\'"));
            }
            if (((Latitude != null) 
                        && (Latitude.HasValue == true))) {
                query = query.AddQueryOption("Latitude", Latitude.Value);
            }
            if (((Longitude != null) 
                        && (Longitude.HasValue == true))) {
                query = query.AddQueryOption("Longitude", Longitude.Value);
            }
            if ((WebFileType != null)) {
                query = query.AddQueryOption("WebFileType", string.Concat("\'", System.Uri.EscapeDataString(WebFileType), "\'"));
            }
            if ((Options != null)) {
                query = query.AddQueryOption("Options", string.Concat("\'", System.Uri.EscapeDataString(Options), "\'"));
            }
            if ((WebSearchOptions != null)) {
                query = query.AddQueryOption("WebSearchOptions", string.Concat("\'", System.Uri.EscapeDataString(WebSearchOptions), "\'"));
            }
            return query;
        }
    }
}
