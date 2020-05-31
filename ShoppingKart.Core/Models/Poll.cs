using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Poll
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int LanguageId { get; set; }
		public string SystemKeyword { get; set; }
		public bool Published { get; set; }
		public bool ShowOnHomepage { get; set; }
		public bool AllowGuestsToVote { get; set; }
		public int DisplayOrder { get; set; }
		public bool LimitedToStores { get; set; }
		public DateTime StartDateUtc { get; set; }
		public DateTime EndDateUtc { get; set; }
	}
	public class PollAnswer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PollId { get; set; }
		public int NumberOfVotes { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class PollVotingRecord
	{
		public int Id { get; set; }
		public int PollAnswerId { get; set; }
		public int CustomerId { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
}
