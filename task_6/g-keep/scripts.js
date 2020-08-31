const add = document.getElementById("add");
const save = document.getElementById("save");
const close = document.getElementById("close");
const noteInit = document.getElementsByClassName("note__init")[0];
const note = document.getElementsByClassName("note")[0];
const modal = document.getElementsByClassName("modal")[0];
const modalContent = document.getElementsByClassName("modal__content")[0];
const textarea = document.getElementById("modal__body");
const search = document.getElementById("search-input");

let checkOnEmpty = () => {
  if (notes.getAll().length === 0) {
    let node = document.createElement("div");
    node.className = "note__init";
    node.innerHTML = "Заметки отсутствуют";

    note.append(node);
  }
}

let render = item => {
  let newNode = document.createElement("div");
  newNode.className = "note__item";
  newNode.setAttribute("data-note-id", item ? item.id : notes.add(textarea.value).id);
  newNode.ondblclick = edit;

  let newNodeText = document.createElement("pre");
  newNodeText.className = "note__text";
  newNodeText.innerHTML = item ? item.value : textarea.value;

  let newNodeDelete = document.createElement("img");
  newNodeDelete.className = "note__delete"
  newNodeDelete.setAttribute("src", "delete.svg");
  newNodeDelete.setAttribute("alt", "delete");
  newNodeDelete.onclick = deleteNote;

  newNode.append(newNodeText);
  newNode.append(newNodeDelete);

  note.append(newNode);
}

let edit = event => {
  console.log(event.target);
}

search.onkeyup = event => {
  note.innerHTML = "";
  
  checkOnEmpty();
  
  notes.getByValue(event.target.value).forEach(item => render(item));
}

add.onclick = event => {
  modal.classList.add("modal-show");
};

close.onclick = event => {
  modal.classList.remove("modal-show");
  textarea.value = "";
};

window.onclick = event => {
  if (event.target == modal) {
    modal.classList.remove("modal-show");
    textarea.value = "";
  }
};

save.onclick = event => {
  modal.classList.remove("modal-show");

  if (document.getElementsByClassName("note__init")[0]) {
    document.getElementsByClassName("note__init")[0].remove();
  }
  
  render();
  
  textarea.value = "";

  if (notes.getAll().length !== 0) {
    noteInit.remove();
  }
};

let deleteNote = event => {
  const target = event.target.parentNode;
  const id = target.getAttribute("data-note-id");

  let notesNode = note.getElementsByClassName("note__item");

  for (let i = 0; i < notesNode.length; i++) {
    if (notesNode[i].getAttribute("data-note-id") === id) {
      notesNode[i].remove();
      notes.deleteById(id);
    }

    checkOnEmpty();
  }
}