using ListAndLinq;

List<Student> student = new()
{
    new Student(){Id = 1, Name1= "trungnghi",Gender =true,Dob = new DateTime(2003,01,01)},
     new Student(){Id = 2, Name1= "Toan thai le",Gender =true,Dob = new DateTime(2003,01,01)},
      new Student(){Id = 3, Name1= "TOAN NOI NHIU",Gender =false,Dob = new DateTime(2003,11,01)},
       new Student(){Id = 4, Name1= "TOAN",Gender =true,Dob = new DateTime(2004,01,01)},
        new Student(){Id = 5, Name1= "NGHIII",Gender =true,Dob = new DateTime(2003,01,11)},
         new Student(){Id = 6, Name1= "trungnghiIII",Gender =true,Dob = new DateTime(2003,01,21)},
          new Student(){Id = 7, Name1= "trungnghiIIEIEIE",Gender =true,Dob = new DateTime(2003,01,31)},



};
//foreach(var stu in student)
//{
//    Console.WriteLine(stu);
//}

//IEnumerator<Student> enu = student.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current.ToString());
//}
////duyen qua list
//student.ForEach(Console.WriteLine);
//linq = languege integrated query
//linq to sql => thay thế cú pháp sql trong c#
//linq to object -=> console
// sql => select * from where group by having order by
//c# => FROM WHERE FRUOP BY HAVING ORDER BY ... SELECT
//linq có 2 dạng
//style 1 => query syntax => dựa theo cú pháp của sql, dễ học, dễ dùng
//style 2=> method syntax => dựa theo lambda = > khó học, khó dùng , nhưng cực nhanh
// hiển thị toàn bộ thông tin sinh viên trong list vs điều kiện id sinh viên phải lớn hơn 2

//foreach(var stu in student)
//{
//    if(stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//var t = from stu in student
//        where stu.Id > 2
//        select stu;

//foreach (var i in t)
//{
//    Console.WriteLine(i);
//}

////====style 1 của linq thu gọn
//foreach (var  i in  from stu in student where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}

//style 2 của linq : method syntax
//var t = student.Where(stu => stu.Id > 2);
//foreach(var i in t)
//{
//    Console.WriteLine(i);
//}

////==== style 2 cua linq : method syntax rut gon
//foreach(var i in student.Where(stu=>stu.Id > 2))
//{
//    Console.WriteLine(i);
//}
//kết hợp s foreach của list
student.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);