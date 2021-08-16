using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotation.Models
{
    public class Member
    {
        [Key]//attribute key จะเทียบเท่ากับ Database คือ Primary key (คือเป็นค่าว่างไม่ได้) ปกติแล้วจะไม่ให้ user เป็นคนกำหนดหรือใส่ค่ามาเองได้
        public int ID { get; set; }

        [Required(ErrorMessage = "กรุณาใส่ UserName")]//attribute Requirde คือกำว่าไม่สามารถให้ค่านี้ว่างได้ และจะส่ง ErrorMessage ออกไปถ้ายังเป็นค่าว่างอยู่
        public string UserName { get; set; }

        [Required(ErrorMessage = "กรุณาใส่เมล์")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "กรุณาใส่รหัสผ่าน")]
        public string Password { get; set; }

        [Required(ErrorMessage = "กรุณาใส่รหัสผ่าน")]
        [Compare("Password",ErrorMessage = "กรุณาใส่รหัสให้ตรงกัน")]
        public string PasswordAgin { get; set; }
        //attribute Compare ทำหน้าที่ตรวจสอบว่าค่าที่ใส่เข้ามาตรงกันกับ Property "Password" มั้ย


    }
}
