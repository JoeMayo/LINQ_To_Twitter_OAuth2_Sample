﻿namespace LINQ_To_Twitter_OAuth2_Sample.Client.Models
{
	// Flatten JSON response from server, classes because items are added and removed from the collection
	public class BrowserTweet
	{
		public bool IsRetweet { get; set; } = false;
		public bool IsNewTweet { get; set; } = false;
		public string? TweetId { get; set; }
		public string? AuthorId { get; set; }
		public string? AuthorProfileImage { get; set; }
		public string? ProfileImageUrl { get; set; }
		public string? Name { get; set; }
		public string? UserName { get; set; }
		public string? Text { get; set; }
		public string? Source { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? Lang { get; set; }
		public string? ConversationId { get; set; }
		public string? ReplySettings { get; set; } // None,Everyone,MentionedUsers,Following
		public int Likes { get; set; }
		public int Retweets { get; set; }
		public int Favorites { get; set; } // #TODO = LIKES
		public List<BrowserTweetMedia>? MediaList { get; set; }
		public List<BrowserTweetHashtag>? Hashtags { get; set; }
		public List<BrowserTweetMention>? Mentions { get; set; }
	}

	public class BrowserTweetHashtag
	{
		public string? Hashtag { get; set; }
	}

	public class BrowserTweetMention
	{
		public string? Mention { get; set; }
	}

	public class BrowserTweetMedia
	{
		public string? MediaKey { get; set; }
		public string? Type { get; set; } // None,AnimatedGif,Photo,Video
		public string? Url { get; set; }
		public string? PreviewImageUrl { get; set; }
		public string? AltText { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int DurationMS { get; set; }
	}
}

