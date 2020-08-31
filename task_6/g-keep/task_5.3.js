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
      id: "id" + this.idCount,
    });

    return {
      value: obj,
      id: "id" + this.idCount++,
    };
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

  getByValue(value) {
    if (typeof value !== "string") {
      console.log("Введите валидный значение");
      return undefined;
    }

    if (value === "") {
      return this.items;
    }

    let arr = [];

    this.items.map(item => {
      return item.value.indexOf(value) !== -1 ? arr.push(item) : null;
    });

    return arr;
  }

  getAll() {
    return this.items;
  }

  deleteById(id) {
    if (typeof id !== "string") {
      console.log("Введите валидный id");
      return undefined;
    }

    let arr = [];

    for (let i = 0; i < this.items.length; i++) {
      if (this.items[i].id !== id) {
        arr.push(this.items[i]);
      }
    }

    this.items = arr;

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

let notes = new Servise();
