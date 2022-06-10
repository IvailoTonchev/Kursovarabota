// See https://aka.ms/new-console-template for more information
using KursovaRabota;
using Microsoft.EntityFrameworkCore;

var db = new KursovaRabotaDbContext();
db.Database.Migrate();
db.Hotels.Add(new KursovaRabota.Models.Hotel {Freerooms=50,Pricefor18orolders=30,Priceforunder18years=20,Priceforover60years=15,Cleaners=5 });
db.SaveChanges();
db.Clients.Add(new Client  {Names = "Patrick Marvin", Roomid = 1, Rooms = 3, People = 3, Nights = 3, Came = 20.00,Gotout=9.00,Payment=240}) ; 
db.SaveChanges();
db.Clients.Add(new Client { Names = "Georgi Georgiev",Roomid=2,Rooms=5,People=5,Nights=5,Came=19.00,Gotout=12.00,Payment=600 });
db.SaveChanges();