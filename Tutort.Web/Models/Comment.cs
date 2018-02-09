using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Tutort.Web.Extensions;

namespace Tutort.Web.Models
{
	public class Comment
	{
		public string Autor { get; set; }
		public string Message{ get; set; }

		public List<string> ReferencedAccounts { get; set; }

		public static Comment GetFromHtml(string html)
		{
			var result = new Comment();
			
			// Get name
			var regex = new Regex("title=\"(?<name>(.*?))\"", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			var match = regex.Match(html);

			result.Autor = match.Groups["name"].Value.Trim();

			regex = new Regex("<span>(?<message>((.|\n)*?))</span>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			match = regex.Match(html);

			result.Message = match.Groups["message"].Value.Trim();

			regex = new Regex("<a class=\"notranslate\" href=\"/(?<ref>((.|\n)*?))/\"", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			var matches = regex.Matches(html);

			result.ReferencedAccounts = matches.Cast<Match>()
				.Where(x => x.Success && x.Groups["ref"].Success)
				.Select(x => x.Groups["ref"].Value)
				.ToList();

			result.Message = result.Message.HtmlToPlainText();

			return result;
		}
	}
}
