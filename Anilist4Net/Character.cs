﻿using System.Linq;
using Anilist4Net.Connections;

namespace Anilist4Net
{
	public class Character
	{
		/// <summary>
		///     The ID of the character
		/// </summary>
		public int Id { get; set; }

		private CharacterName Name { get; set; }

		/// <summary>
		///     The character's Romaji first name
		/// </summary>
		public string FirstName => Name.First;

		/// <summary>
		///     The character's Romaji last name
		/// </summary>
		public string LastName => Name.Last;

		/// <summary>
		///     The character's Romaji name
		/// </summary>
		public string FullName => Name.First;

		/// <summary>
		///     The character's native name (usually Japanese)
		/// </summary>
		public string NativeName => Name.Native;

		/// <summary>
		///     Alternative names for the character (i.e. Nicknames)
		/// </summary>
		public string[] AlternativeNames => Name.Alternative;

		private CharacterImage Image { get; set; }

		/// <summary>
		///     The character's image URL (large)
		/// </summary>
		public string ImageLarge => Image.Large;

		/// <summary>
		///     The character's image URL (medium)
		/// </summary>
		public string ImageMedium => Image.Medium;

		/// <summary>
		///     The character's description in Markdown
		/// </summary>
		public string DescriptionMd { get; set; }

		/// <summary>
		///     The character's description in HTML
		/// </summary>
		public string DescriptionHtml { get; set; }

		/// <summary>
		///     The character's Anilist URL
		/// </summary>
		public string SiteUrl { get; set; }

		private MediaNodeConnection MediaEdge { get; set; }

		/// <summary>
		///     The IDs of media this character is in
		/// </summary>
		public int[] MediaIds => MediaEdge.Nodes.Select(n => n.Id).ToArray();

		/// <summary>
		///     How many users have favourited this character
		/// </summary>
		public int Favourites { get; set; }

		/// <summary>
		///     Mods Notes
		/// </summary>
		public string ModNotes { get; set; }
	}

	internal class CharacterResponse
	{
		public Character Character { get; set; }
	}

	internal class CharacterName
	{
		public string   First       { get; set; }
		public string   Last        { get; set; }
		public string   Full        { get; set; }
		public string   Native      { get; set; }
		public string[] Alternative { get; set; }
	}

	internal class CharacterImage
	{
		public string Large  { get; set; }
		public string Medium { get; set; }
	}
}