﻿using System;
using Newtonsoft.Json;

namespace Ivvy.Venue.Bookings
{
	/// <summary>Booking custom field</summary>
	/// <remarks>Missing from the Master Branch
	/// "customFields": [{
	//  "fieldId": 9,
	//  "displayName": "Web Description 1",
	//  "fieldValue": null
	/// </remarks>
	public class CustomField
	{
		[JsonProperty( "fieldId" )]
		public int FieldId { get; set; }

		[JsonProperty( "displayName" )]
		public string DisplayName { get; set; }

		/// <summary>Custom field values can be anything</summary>
		[JsonProperty( "fieldValue" )]
		public object FieldValue { get; set; }
	}
}


