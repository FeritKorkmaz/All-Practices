function newElement() {
  let add = document.querySelector("#task").value;
  if (add != "") {
    let UlDom = document.querySelector("#list");
    let liDOM = document.createElement("li");
    let Btn = document.createElement("button");
    Btn.innerHTML = `<span>X</span>`;
    Btn.classList.add("btn", "btn-danger", "float-right");
    liDOM.innerHTML = add;
    UlDom.append(liDOM);
    Btn.addEventListener("click", () => {
      UlDom.removeChild(liDOM);
    });
    liDOM.appendChild(Btn);
  }
}
