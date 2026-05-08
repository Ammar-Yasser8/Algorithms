/*
Star Pattern: Centered Pyramid
------------------------------
Example for rows = 5:
    *
   ***
  *****
 *******
*********
*/

int rows = 5;

for (int i = 1; i <= rows; i++)
{
    Console.Write(new string(' ', rows - i));
    Console.WriteLine(new string('*', i * 2 - 1));
}
