﻿using System;
using System.Text.Json.Serialization;

namespace SoundCloudExplode.Track;

public class TrackInformation
{
    [JsonPropertyName("artwork_url")]
    public Uri? ArtworkUrl { get; set; }

    [JsonPropertyName("caption")]
    public object? Caption { get; set; }

    [JsonPropertyName("commentable")]
    public bool Commentable { get; set; }

    [JsonPropertyName("comment_count")]
    public long? CommentCount { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("downloadable")]
    public bool Downloadable { get; set; }

    [JsonPropertyName("download_count")]
    public long? DownloadCount { get; set; }

    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("full_duration")]
    public long? FullDuration { get; set; }

    [JsonPropertyName("embeddable_by")]
    public string? EmbeddableBy { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("has_downloads_left")]
    public bool HasDownloadsLeft { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; } = default!;

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("label_name")]
    public object? LabelName { get; set; }

    [JsonPropertyName("last_modified")]
    public DateTimeOffset LastModified { get; set; }

    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("likes_count")]
    public long? LikesCount { get; set; }

    [JsonPropertyName("permalink")]
    public string? Permalink { get; set; }

    [JsonPropertyName("permalink_url")]
    public Uri? PermalinkUrl { get; set; }

    [JsonPropertyName("playback_count")]
    public long? PlaybackCount { get; set; }

    [JsonPropertyName("public")]
    public bool Public { get; set; }

    [JsonPropertyName("publisher_metadata")]
    public PublisherMetadata? PublisherMetadata { get; set; }

    [JsonPropertyName("purchase_title")]
    public object? PurchaseTitle { get; set; }

    [JsonPropertyName("purchase_url")]
    public object? PurchaseUrl { get; set; }

    [JsonPropertyName("release_date")]
    public object? ReleaseDate { get; set; }

    [JsonPropertyName("reposts_count")]
    public long? RepostsCount { get; set; }

    [JsonPropertyName("secret_token")]
    public object? SecretToken { get; set; }

    [JsonPropertyName("sharing")]
    public string? Sharing { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("streamable")]
    public bool Streamable { get; set; }

    [JsonPropertyName("tag_list")]
    public string? TagList { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("uri")]
    public Uri? Uri { get; set; }

    [JsonPropertyName("urn")]
    public string? Urn { get; set; }

    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }

    [JsonPropertyName("visuals")]
    public object? Visuals { get; set; }

    [JsonPropertyName("waveform_url")]
    public Uri? WaveformUrl { get; set; }

    [JsonPropertyName("display_date")]
    public DateTimeOffset DisplayDate { get; set; }

    [JsonPropertyName("media")]
    public Media? Media { get; set; }

    [JsonPropertyName("monetization_model")]
    public string? MonetizationModel { get; set; }

    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("user")]
    public User.User? User { get; set; }

    /// <summary>
    /// Name of playlist/album
    /// </summary>
    public string? PlaylistName { get; set; }
}

public class Media
{
    [JsonPropertyName("transcodings")]
    public Transcoding[]? Transcodings { get; set; }
}

public class Transcoding
{
    [JsonPropertyName("url")]
    public Uri? Url { get; set; }

    [JsonPropertyName("preset")]
    public string? Preset { get; set; }

    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("snipped")]
    public bool Snipped { get; set; }

    [JsonPropertyName("format")]
    public Format? Format { get; set; }

    [JsonPropertyName("quality")]
    public string? Quality { get; set; }
}

public class Format
{
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }
}

public class PublisherMetadata
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("urn")]
    public string? Urn { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("contains_music")]
    public bool ContainsMusic { get; set; }
}