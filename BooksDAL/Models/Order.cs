﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksDAL.Models
{
    public class Order
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Wprowadz imię")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Wprowadz adres")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Wprowadz miasto")]
        [StringLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić numer telefonu")]
        [StringLength(20)]
        [RegularExpression(@"(\+\d{2})*[\d\s-]+", ErrorMessage = "Błędny format numeru telefonu.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Wprowadź swój adres e-mail.")]
        [EmailAddress(ErrorMessage = "Błędny format adresu e-mail.")]
        public string Email { get; set; }

        public string Comment { get; set; }

        public DateTime AddedDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal OrderValue { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public List<OrderPosition> OrderPositions { get; set; }
    }


    public enum OrderStatus
    {
        Nowe,
        Zrealizowane
    }
}

