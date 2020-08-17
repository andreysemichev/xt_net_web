function calculator(str) {
  const items = str.match(/(\d+\.\d+)|(\d+)|(\+|\-|\/|\*|\=)/g);
  let result = 0;

  for (let i = 1; i < items.length; i++) {
    switch (items[i]) {
      case "+":
        result += parseFloat(items[i + 1]);
        break;

      case "-":
        result -= parseFloat(items[i + 1]);
        break;

      case "*":
        result *= parseFloat(items[i + 1]);
        break;

      case "/":
        result /= parseFloat(items[i + 1]);
        break;

      case "=":
        console.log(result.toFixed(2));
        break;
    }
  }
}

calculator("3.5 +4*10-5.3 /5 =");
