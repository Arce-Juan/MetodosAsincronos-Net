using EjemploAsincronia.Consola.Dominio;
using System;

var cafeteria = new Cafeteria();
//cafeteria.PrepararCafeConLeche();
await cafeteria.PrepararCafeConLecheAsync();
Console.ReadLine();