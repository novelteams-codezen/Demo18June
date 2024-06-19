using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Demo18June.Models
{
    /// <summary> 
    /// Represents a token entity with essential details
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Required field RefreshToken of the Token 
        /// </summary>
        [Required]
        public string RefreshToken { get; set; }
    }
}