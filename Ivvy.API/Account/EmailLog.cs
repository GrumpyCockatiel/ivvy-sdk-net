using Ivvy.Json;
using Newtonsoft.Json;
using System;
using RS = System.Runtime.Serialization;

namespace Ivvy.Account
{
    public class EmailLog : ISerializable
    {
        public enum RefTypes
        {
            Other = 0,
            Contact = 1,
            Event = 2,
            Membership = 3,
            Abstract = 4,
            Registration = 5,
            Invoice = 6,
            Author = 7,
            Task = 8,
            [RS.EnumMember( Value = "Credit Note" )]
            CreditNote = 9,
            Survey = 10,
            [RS.EnumMember( Value = "Venue Marketplace" )]
            VenueMarketplace = 11,
            Booking = 12,
            Company = 13,
            [RS.EnumMember( Value = "Floor Plan" )]
            FloorPlan = 14
        }

        public enum EmailTypes
        {
            Unknown = 0,
            [RS.EnumMember( Value = "Completed Event Registration" )]
            CompletedEventRegistration = 1,
            [RS.EnumMember( Value = "Completed Event Registration (Waiting on Payment)" )]
            CompletedEventRegistrationWaitingonPayment = 2,
            [RS.EnumMember( Value = "Accommodation Confirmation" )]
            AccommodationConfirmation = 3,
            [RS.EnumMember( Value = "Travel Confirmation" )]
            TravelConfirmation = 4,
            [RS.EnumMember( Value = "Registration Payment Reminder" )]
            RegistrationPaymentReminder = 5,
            [RS.EnumMember( Value = "Exhibitor Final Confirmation" )]
            ExhibitorFinalConfirmation = 8,
            [RS.EnumMember( Value = "Abstract/Paper Submission Created" )]
            AbstractOrPaperSubmissionCreated = 11,
            [RS.EnumMember( Value = "Abstract/Paper Changes Requested" )]
            AbstractOrPaperChangesRequested = 12,
            [RS.EnumMember( Value = "Abstract/Paper Submission Rejected" )]
            AbstractOrPaperSubmissionRejected = 13,
            [RS.EnumMember( Value = "Abstract/Paper Submission Accepted" )]
            AbstractOrPaperSubmissionAccepted = 14,
            [RS.EnumMember( Value = "Abstract/Paper Reviewer Added" )]
            AbstractOrPaperReviewerAdded = 15,
            [RS.EnumMember( Value = "Contact Changed" )]
            ContactChanged = 16,
            [RS.EnumMember( Value = "Hotel Changed" )]
            HotelChanged = 17,
            [RS.EnumMember( Value = "Flight Changed" )]
            FlightChanged = 18,
            [RS.EnumMember( Value = "Tickets Changed" )]
            TicketsChanged = 19,
            [RS.EnumMember( Value = "Exhibitor Confirmation" )]
            ExhibitorConfirmation = 20,
            [RS.EnumMember( Value = "Session Confirmation" )]
            SessionConfirmation = 21,
            [RS.EnumMember( Value = "Session Changed" )]
            SessionChanged = 22,
            [RS.EnumMember( Value = "Abstract Changed" )]
            AbstractChanged = 23,
            [RS.EnumMember( Value = "Final Confirmation" )]
            FinalConfirmation = 24,
            [RS.EnumMember( Value = "Event Feedback" )]
            EventFeedback = 30,
            [RS.EnumMember( Value = "Event Reminder" )]
            EventReminder = 31,
            Abstract = 26,
            [RS.EnumMember( Value = "API Leadtracker" )]
            ApiLeadtracker = 27,
            [RS.EnumMember( Value = "Contact Subscribed" )]
            ContactSubscribed = 28,
            [RS.EnumMember( Value = "Transfer Changed" )]
            TransferChanged = 29,
            [RS.EnumMember( Value = "Password Reset" )]
            PasswordReset = 1000,
            Notification = 1001,
            Task = 1002,
            Statement = 1500,
            Invoice = 1501,
            [RS.EnumMember( Value = "Credit Note" )]
            CreditNote = 1502,
            [RS.EnumMember( Value = "Membership Signup" )]
            MembershipSignup = 2000,
            [RS.EnumMember( Value = "Membership Renewal" )]
            MembershipRenewal = 2001,
            [RS.EnumMember( Value = "Renewal Notice" )]
            RenewalNotice = 2002,
            Survey = 3000,
            [RS.EnumMember( Value = "New Company Added" )]
            NewCompanyAdded = 1003,
            [RS.EnumMember( Value = "Venue Booking Document" )]
            VenueBookingDocument = 4000,
            [RS.EnumMember( Value = "Venue Booking Floor Plan" )]
            VenueBookingFloorPlan = 4001,
            [RS.EnumMember( Value = "Incomplete Registration" )]
            IncompleteRegistration = 32
        }

        [JsonProperty( "id" )]
        public string Id { get; set; }

        [JsonProperty( "contactId" )]
        public int? ContactId { get; set; }

        [JsonProperty( "eventId" )]
        public int? EventId { get; set; }

        [JsonProperty( "userId" )]
        public int? UserId { get; set; }

        [JsonProperty( "refType" )]
        public RefTypes EmailRefType { get; set; }

        [JsonProperty( "type" )]
        public EmailTypes EmailType { get; set; }

        [JsonProperty( "refId" )]
        public int? RefId { get; set; }

        [JsonProperty( "from" )]
        public string FromAddress { get; set; }

        [JsonProperty( "to" )]
        public string ToAddress { get; set; }

        [JsonProperty( "bcc" )]
        public string BccAddress { get; set; }

        [JsonProperty( "subject" )]
        public string Subject { get; set; }

        [JsonProperty( "body" )]
        public string Body { get; set; }

        [JsonProperty( "sentTime" )]
        public DateTime SentTime { get; set; }

        [JsonProperty( "success" )]
        public bool Success { get; set; }
    }
}
