window.mudDragAndDrop = {
    initDropZone: id => {
        const elem = document.getElementById("mud-drop-zone-" + id);
        if (elem) {
            elem.addEventListener("dragover", (event) => event.preventDefault());
            elem.addEventListener("dragstart", (event) => event.dataTransfer.setData("", event.target.id));
        }
    }
};