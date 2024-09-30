using System;

string input = string.Empty;
string operand1 = string.Empty;
string operand2 = string.Empty;
char operation = '\0';
double result = 0.0;

Console.WriteLine("CALCULADORA");
Console.WriteLine("Ingrese la operación en formato: número1 operador número2 (ejemplo: 3 + 2)");

while (true) {
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    char ch = keyInfo.KeyChar;

    if (char.IsDigit(ch) || ch == '.') {
        input += ch;
        Console.Write(ch);
    } else if (ch == '+' || ch == '-' || ch == '*' || ch == '/') {
        operand1 = input;
        operation = ch;
        input = string.Empty;
        Console.Write(" " + ch + " ");
    } else if (ch == '=' || ch == '\r') {
        operand2 = input;
        double num1, num2;
        double.TryParse(operand1, out num1);
        double.TryParse(operand2, out num2);

        switch (operation) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
        }
        Console.WriteLine(" = " + result);
        input = string.Empty;
        operand1 = string.Empty;
        operand2 = string.Empty;
        operation = '\0';
    } else if (ch == '\b') {
        if (input.Length > 0) {
            input = input.Substring(0, input.Length - 1);
            Console.Write("\b \b");
        }
    }
}