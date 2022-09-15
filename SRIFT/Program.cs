static bool Prov(string Stroka)
{
    foreach (char c in Stroka)
    {
        if (int.TryParse(c.ToString(), out var bar) || c == ' ' || c == '\\' || c == '.'||c==',')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    return true;
}
var wd = Console.WindowWidth / 2;
var ht = Console.WindowHeight / 2;
Console.Write("Введите цифры от 1 -9 с символами разделителями (\\) ( ) (,) (.): ");
var numb = Console.ReadLine();
while (!Prov(numb))
{
    Console.WriteLine("Ввод не корректен!");
     numb = Console.ReadLine();
    Console.Clear();

}
var col = numb.Length;

var kol = 0;
Console.WriteLine(col);
int x=wd-col*3 ,y=ht ;
while ( kol < col )
{
    y = ht ;
    Console.WriteLine(kol);
    
    switch (numb[kol])
    {
        case '0':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ','█', '█', '█', ' '},
                            { '█', '█', '█',' ' ,'█', '█', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { ' ', '█', '█', '█','█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                

                x += 7;
              
               
               

            }
            break;
        case '1':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', '█', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
               
            }
            break;
        case '2':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', ' ', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', '█','█', '█', '█', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '3':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '4':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { '█', '█', ' ','█', '█', ' ', ' '},
                            { '█', '█', ' ','█', '█', ' ', ' '},
                            { '█', '█', ' ','█', '█', ' ', ' '},
                            { '█', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '5':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { '█', ' ', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', '█','█', '█', ' ', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '6':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '7':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '8':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '9':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', '█', '█','█', '█', ' ', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', '█', '█','█', '█', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case ' ':
            {
                var Save = x;
                char[,] Cifra =
                {
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '\\':
            {
                var Save = x;
                char[,] Cifra =
                {
                           { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ','█', '█', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', '█', '█',' ', ' ', ' ', ' '},
                            { ' ', '█', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case '.':
            {
                var Save = x;
                char[,] Cifra =
                {
                              { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', '█', '█',' ', ' ', ' ', ' '},
                            { ' ', '█', '█',' ', ' ', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
        case ',':
            {
                var Save = x;
                char[,] Cifra =
                {
                             { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', '█', '█',' ', ' ', ' ', ' '}
                        };
                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                {
                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                    {

                        Console.SetCursorPosition(x, y);
                        Console.Write(Cifra[i, j]);
                    }
                }
                x += 7;
            }
            break;
      


    
            
    }
    
    kol++;
}
   

