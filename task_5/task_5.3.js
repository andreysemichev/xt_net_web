class Servise {
  constructor() {
    this.idCount = 0;
    this.items = [];
  }

  add(obj) {
    if (!obj) {
      console.log("Укажите объект для записи");
      return;
    }

    this.items.push({
      value: obj,
      id: "id" + this.idCount++,
    });
  }

  getById(id) {
    if (typeof id !== "string") {
      console.log("Введите валидный id");
      return undefined;
    }

    return this.items.find((item) => {
      if (item && item.id === id) {
        return true;
      }
    });
  }

  getAll() {
    return this.items;
  }

  deleteById(id) {
    if (typeof id !== "string") {
      console.log("Введите валидный id");
      return undefined;
    }

    for (let i = 0; i < this.items.length; i++) {
      if (this.items[i].id === id) {
        this.items[i] = undefined;
        break;
      }
    }

    return true;
  }

  updateById(id, obj) {
    if (typeof id !== "string") {
      console.log("Введите валидный id");
      return undefined;
    }

    if (!obj) {
      console.log("Укажите объект для записи");
      return;
    }

    let result;

    for (let i = 0; i < this.items.length; i++) {
      if (this.items[i].id === id) {
        for (let prop in this.items[i].value) {
          this.items[i].value[prop] =
            obj[prop] === undefined ? this.items[i].value[prop] : obj[prop];
        }
        break;
      }
    }

    return result;
  }

  replaceById(id, obj) {
    if (typeof id !== "string") {
      console.log("Введите валидный id");
      return undefined;
    }

    if (!obj) {
      console.log("Укажите объект для записи");
      return;
    }

    let result;

    for (let i = 0; i < this.items.length; i++) {
      if (this.items[i].id === id) {
        this.items[i].value = obj;
        result = this.items[i];
        break;
      }
    }

    return result;
  }
}

let servise = new Servise();

servise.add({ obj: true });
servise.add({ obj: "123" });
servise.add({ obj: "456" });
servise.add({ obj: false });

// console.log(servise.getById("id2"));
console.log(servise.updateById("id2", { obj: "1" }));
// console.log(servise.deleteById("id2"));
// console.log(servise.getById("id2"));
