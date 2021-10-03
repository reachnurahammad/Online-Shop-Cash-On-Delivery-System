using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
      
        public byte[] Image { get; set; }
       
        public string ImageFile { get; set;}
   
    }
  
    public class Dasktop
    {
        public int Id { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
 
        public byte[] Image { get; set; }
    
        public string ImageFile { get; set; }

    }

    public class Laptop
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
     
        public byte[] Image { get; set; }
 
        public string ImageFile { get; set; }
    }
    public class Baik
    {
        public int Id { get; set; }
        [Required]
        public string BranD { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
        
        public byte[] Image { get; set; }
    
        public string ImageFile { get; set; }
    }
    public class Watch {
        public int Id { get; set; }
        [Required]
        public string BranD { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
     
        public byte[] Image { get; set; }
  
        public string ImageFile { get; set; }
    }
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        public string BranD { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
       
        public byte[] Image { get; set; }
     
        public string ImageFile { get; set; }
    }
    public class Tv
    {
        public int Id { get; set; }
        [Required]
        public string BranD { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
       
        public byte[] Image { get; set; }
      
        public string ImageFile { get; set; }
    }
    public class Refrigerator
    {
        public int Id { get; set; }
        [Required]
        public string BranD { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
      
        public byte[] Image { get; set; }
        
        public string ImageFile { get; set; }
    }
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Role { get; set; }
        public bool IsActive { get; set; }
    }
    public class OrderAddress
    {
        public int Id { get; set; }
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Division { get; set; }
        [Required]
        public int City { get; set; }
        [Required]
        public string Area { get; set; }   
    }

     //.............//

    public class Aarong
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
    
        public byte[] Image { get; set; }
 
        public string ImageFile { get; set; }
    }
    public class BdFood
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
      
        public byte[] Image { get; set; }
  
        public string ImageFile { get; set; }
    }

    public class Lux
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
  
        public byte[] Image { get; set; }
      
        public string ImageFile { get; set; }
    }
    public class Shopno
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
    
        public byte[] Image { get; set; }
    
        public string ImageFile { get; set; }
    }
    public class Unilever
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
        
        public byte[] Image { get; set; }
      
        public string ImageFile { get; set; }
    }
    public class AmanFeed
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
       
        public byte[] Image { get; set; }
    
        public string ImageFile { get; set; }
    }
    public class Tshirt
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
       
        public byte[] Image { get; set; }
     
        public string ImageFile { get; set; }
        
    }
    public class Aci
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
       
        public byte[] Image { get; set; }
      
        public string ImageFile { get; set; }
    }
    public class Dano
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string TextBox { get; set; }
        public byte[] Image { get; set; }
        public string ImageFile { get; set; }
    }
    public class Fresh
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string TextBox { get; set; }
        public byte[] Image { get; set; }
        public string ImageFile { get; set; }
    }
    public class Lifebuoy
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
    
        public byte[] Image { get; set; }
   
        public string ImageFile { get; set; }
    }
    public class Primier
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
    
        public byte[] Image { get; set; }
     
        public string ImageFile { get; set; }
    }
    public class Jamuna
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        public string TextBox { get; set; }
    
        public byte[] Image { get; set; }
    
        public string ImageFile { get; set; }
    }
    public class Efood
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TextBox { get; set; }
     
        public byte[] Image { get; set; }
     
        public string ImageFile { get; set; }
    }
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(11)]
        public string PnoneNumber { get; set; }
        [Required]
        public double Email { get; set; }
        [Required]
        public string TextBox { get; set; }
  
    }
}
