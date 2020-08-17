function removeRepeatedCharacters(inputString) {
  const repeat = checkForRepeat(inputString);

  const result = inputString.split("").filter(item => {
    return repeat.indexOf(item) == -1;
  });

  return result.join("");
}

function checkForRepeat(inputString) {
  const ignore = [" ", "?", "!", ":", ";", ",", "."];
  const words = inputString.split(" ");
  let result = [];

  words.forEach(item => {
    for (let i = 0; i <= item.length; i++) {
      let check1 = result.indexOf(item[i]) == -1;
      let check2 = ignore.indexOf(item[i]) == -1;
      let check3 = item.indexOf(item[i]) != item.lastIndexOf(item[i]);

      if (check1 && check2 && check3) {
        result.push(item[i]);
      }
    }
  });

  return result;
}

console.log(removeRepeatedCharacters("У попа была собака"));
