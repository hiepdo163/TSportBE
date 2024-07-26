using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSport.Api.Models.ResponseModels.Account
{
    public class GetAccountResponse
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string Email { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public DateOnly? Dob { get; set; }

        public string SupabaseId { get; set; } = null!;

        public string Role { get; set; } = null!;

        public string? Status { get; set; }

    }
}