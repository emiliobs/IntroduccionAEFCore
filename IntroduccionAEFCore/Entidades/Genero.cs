﻿namespace IntroduccionAEFCore.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        //[StringLength(maximumLength:150)]
        public String Nombre { get; set; } = null!;
    }
}
