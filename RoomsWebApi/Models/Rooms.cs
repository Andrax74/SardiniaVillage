using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoomsWebApi.Models
{
    [Table("Stanze")]
    public class Rooms
    {
        public enum StateRoom
        {
            Libera = 0,
            Occupata = 1,
            NonDisponibile = 2
        }

        [Key]
        [Column("IdStanza")]
        public int Id { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Il numero minimo di caratteri è 5")]
        [MaxLength(40, ErrorMessage = "Il numero massimo di caratteri è 40")]
        public string Description { get; set; }
        public string Name { get; set; }
        [Range(10, 1000, ErrorMessage = "I valori del prezzo devono essere compresi fra 10 e 1000")]
        [NotMapped]
        public double? Price { get; set; }
        //public bool IsFree { get; set; }
        public StateRoom State { get; set; }
        [Range(1, 5, ErrorMessage = "Il numero dei letti devo essere compreso fra 1 e 5")]
        public int? Beds { get; set; }
        public string Image { get; set; }
        
        /*
        public Rooms(int id, string description, string name, double price, bool isFree, int beds, string image)
        {
            Id = id;
            Description = description;
            Name = name;
            Price = price;
            IsFree = isFree;
            Beds = beds;
            Image = image;
        }
        */
    }
}
