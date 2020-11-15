namespace YoutubeWebhook.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
	using System.Text.Json.Serialization;
	using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Thumbnail2
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }

    public class Thumbnail
    {
        [JsonPropertyName("thumbnails")]
        public List<Thumbnail2> Thumbnails { get; set; }
    }

    public class Run
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class AccessibilityData
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class Accessibility
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityData AccessibilityData { get; set; }
    }

    public class Title
    {
        [JsonPropertyName("runs")]
        public List<Run> Runs { get; set; }

        [JsonPropertyName("accessibility")]
        public Accessibility Accessibility { get; set; }
    }

    public class PublishedTimeText
    {
        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public class ViewCountText
    {
        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public class WebCommandMetadata
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webPageType")]
        public string WebPageType { get; set; }

        [JsonPropertyName("rootVe")]
        public int RootVe { get; set; }
    }

    public class CommandMetadata
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata WebCommandMetadata { get; set; }
    }

    public class WatchEndpoint
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }
    }

    public class NavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("watchEndpoint")]
        public WatchEndpoint WatchEndpoint { get; set; }
    }

    public class Icon
    {
        [JsonPropertyName("iconType")]
        public string IconType { get; set; }
    }

    public class MetadataBadgeRenderer
    {
        [JsonPropertyName("icon")]
        public Icon Icon { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public class OwnerBadge
    {
        [JsonPropertyName("metadataBadgeRenderer")]
        public MetadataBadgeRenderer MetadataBadgeRenderer { get; set; }
    }

    public class ShortViewCountText
    {
        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public class Run2
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Text
    {
        [JsonPropertyName("runs")]
        public List<Run2> Runs { get; set; }
    }

    public class Icon2
    {
        [JsonPropertyName("iconType")]
        public string IconType { get; set; }
    }

    public class WebCommandMetadata2
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }
    }

    public class CommandMetadata2
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata2 WebCommandMetadata { get; set; }
    }

    public class WebCommandMetadata3
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }

        [JsonPropertyName("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public class CommandMetadata3
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata3 WebCommandMetadata { get; set; }
    }

    public class CreatePlaylistServiceEndpoint
    {
        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }

        [JsonPropertyName("params")]
        public string Params { get; set; }
    }

    public class OnCreateListCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata3 CommandMetadata { get; set; }

        [JsonPropertyName("createPlaylistServiceEndpoint")]
        public CreatePlaylistServiceEndpoint CreatePlaylistServiceEndpoint { get; set; }
    }

    public class AddToPlaylistCommand
    {
        [JsonPropertyName("openMiniplayer")]
        public bool OpenMiniplayer { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("listType")]
        public string ListType { get; set; }

        [JsonPropertyName("onCreateListCommand")]
        public OnCreateListCommand OnCreateListCommand { get; set; }

        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }
    }

    public class Action
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("addToPlaylistCommand")]
        public AddToPlaylistCommand AddToPlaylistCommand { get; set; }
    }

    public class SignalServiceEndpoint
    {
        [JsonPropertyName("signal")]
        public string Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<Action> Actions { get; set; }
    }

    public class ServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata2 CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public SignalServiceEndpoint SignalServiceEndpoint { get; set; }
    }

    public class MenuServiceItemRenderer
    {
        [JsonPropertyName("text")]
        public Text Text { get; set; }

        [JsonPropertyName("icon")]
        public Icon2 Icon { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public ServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("menuServiceItemRenderer")]
        public MenuServiceItemRenderer MenuServiceItemRenderer { get; set; }
    }

    public class AccessibilityData2
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class Accessibility2
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityData2 AccessibilityData { get; set; }
    }

    public class MenuRenderer
    {
        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibility")]
        public Accessibility2 Accessibility { get; set; }
    }

    public class Menu
    {
        [JsonPropertyName("menuRenderer")]
        public MenuRenderer MenuRenderer { get; set; }
    }

    public class AccessibilityData3
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class Accessibility3
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityData3 AccessibilityData { get; set; }
    }

    public class Text2
    {
        [JsonPropertyName("accessibility")]
        public Accessibility3 Accessibility { get; set; }

        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public class ThumbnailOverlayTimeStatusRenderer
    {
        [JsonPropertyName("text")]
        public Text2 Text { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }
    }

    public class UntoggledIcon
    {
        [JsonPropertyName("iconType")]
        public string IconType { get; set; }
    }

    public class ToggledIcon
    {
        [JsonPropertyName("iconType")]
        public string IconType { get; set; }
    }

    public class WebCommandMetadata4
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }

        [JsonPropertyName("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public class CommandMetadata4
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata4 WebCommandMetadata { get; set; }
    }

    public class Action2
    {
        [JsonPropertyName("addedVideoId")]
        public string AddedVideoId { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }
    }

    public class PlaylistEditEndpoint
    {
        [JsonPropertyName("playlistId")]
        public string PlaylistId { get; set; }

        [JsonPropertyName("actions")]
        public List<Action2> Actions { get; set; }
    }

    public class WebCommandMetadata5
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }

        [JsonPropertyName("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public class CommandMetadata5
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata5 WebCommandMetadata { get; set; }
    }

    public class CreatePlaylistServiceEndpoint2
    {
        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }

        [JsonPropertyName("params")]
        public string Params { get; set; }
    }

    public class OnCreateListCommand2
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata5 CommandMetadata { get; set; }

        [JsonPropertyName("createPlaylistServiceEndpoint")]
        public CreatePlaylistServiceEndpoint2 CreatePlaylistServiceEndpoint { get; set; }
    }

    public class AddToPlaylistCommand2
    {
        [JsonPropertyName("openMiniplayer")]
        public bool OpenMiniplayer { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("listType")]
        public string ListType { get; set; }

        [JsonPropertyName("onCreateListCommand")]
        public OnCreateListCommand2 OnCreateListCommand { get; set; }

        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }
    }

    public class Action3
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("addToPlaylistCommand")]
        public AddToPlaylistCommand2 AddToPlaylistCommand { get; set; }
    }

    public class SignalServiceEndpoint2
    {
        [JsonPropertyName("signal")]
        public string Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<Action3> Actions { get; set; }
    }

    public class UntoggledServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata4 CommandMetadata { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public PlaylistEditEndpoint PlaylistEditEndpoint { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public SignalServiceEndpoint2 SignalServiceEndpoint { get; set; }
    }

    public class WebCommandMetadata6
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }

        [JsonPropertyName("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public class CommandMetadata6
    {
        [JsonPropertyName("webCommandMetadata")]
        public WebCommandMetadata6 WebCommandMetadata { get; set; }
    }

    public class Action4
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("removedVideoId")]
        public string RemovedVideoId { get; set; }
    }

    public class PlaylistEditEndpoint2
    {
        [JsonPropertyName("playlistId")]
        public string PlaylistId { get; set; }

        [JsonPropertyName("actions")]
        public List<Action4> Actions { get; set; }
    }

    public class ToggledServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public CommandMetadata6 CommandMetadata { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public PlaylistEditEndpoint2 PlaylistEditEndpoint { get; set; }
    }

    public class AccessibilityData4
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class UntoggledAccessibility
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityData4 AccessibilityData { get; set; }
    }

    public class AccessibilityData5
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class ToggledAccessibility
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityData5 AccessibilityData { get; set; }
    }

    public class ThumbnailOverlayToggleButtonRenderer
    {
        [JsonPropertyName("isToggled")]
        public bool IsToggled { get; set; }

        [JsonPropertyName("untoggledIcon")]
        public UntoggledIcon UntoggledIcon { get; set; }

        [JsonPropertyName("toggledIcon")]
        public ToggledIcon ToggledIcon { get; set; }

        [JsonPropertyName("untoggledTooltip")]
        public string UntoggledTooltip { get; set; }

        [JsonPropertyName("toggledTooltip")]
        public string ToggledTooltip { get; set; }

        [JsonPropertyName("untoggledServiceEndpoint")]
        public UntoggledServiceEndpoint UntoggledServiceEndpoint { get; set; }

        [JsonPropertyName("toggledServiceEndpoint")]
        public ToggledServiceEndpoint ToggledServiceEndpoint { get; set; }

        [JsonPropertyName("untoggledAccessibility")]
        public UntoggledAccessibility UntoggledAccessibility { get; set; }

        [JsonPropertyName("toggledAccessibility")]
        public ToggledAccessibility ToggledAccessibility { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public class Run3
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Text3
    {
        [JsonPropertyName("runs")]
        public List<Run3> Runs { get; set; }
    }

    public class ThumbnailOverlayNowPlayingRenderer
    {
        [JsonPropertyName("text")]
        public Text3 Text { get; set; }
    }

    public class ThumbnailOverlay
    {
        [JsonPropertyName("thumbnailOverlayTimeStatusRenderer")]
        public ThumbnailOverlayTimeStatusRenderer ThumbnailOverlayTimeStatusRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayToggleButtonRenderer")]
        public ThumbnailOverlayToggleButtonRenderer ThumbnailOverlayToggleButtonRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayNowPlayingRenderer")]
        public ThumbnailOverlayNowPlayingRenderer ThumbnailOverlayNowPlayingRenderer { get; set; }
    }

    public class GridVideoRenderer
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("title")]
        public Title Title { get; set; }

        [JsonPropertyName("publishedTimeText")]
        public PublishedTimeText PublishedTimeText { get; set; }

        [JsonPropertyName("viewCountText")]
        public ViewCountText ViewCountText { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public NavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("ownerBadges")]
        public List<OwnerBadge> OwnerBadges { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("shortViewCountText")]
        public ShortViewCountText ShortViewCountText { get; set; }

        [JsonPropertyName("menu")]
        public Menu Menu { get; set; }

        [JsonPropertyName("thumbnailOverlays")]
        public List<ThumbnailOverlay> ThumbnailOverlays { get; set; }
    }

    public class YoutubeVideoBlock
    {
        [JsonPropertyName("gridVideoRenderer")]
        public GridVideoRenderer GridVideoRenderer { get; set; }
    }
}