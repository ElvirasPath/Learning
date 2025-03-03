const playground = document.getElementById("playground");

//playground.append("Wizard 🧙", " ", "🔮 Crystal Ball", " ", "📕 Spell book");

const magicalOrb = document.createElement("div");
magicalOrb.textContent = "🔮";
playground.append(magicalOrb);

//Modifying text content

const scrollOfWisdom = document.createElement("p");
playground.append(scrollOfWisdom);

scrollOfWisdom.innerText = "Ancient wisdom lies within";
console.log(scrollOfWisdom.innerText); // Only shows the visible text

// concole.log(playground.textContent) Shows all text, including the hidden paragraphs

// Working with HTMl-content

const spellbook = document.createElement("div");
spellbook.innerHTML =
  "<p>Spells include: <strong>Levitation</strong> and <em>Invisibility</em>!</p>";
playground.append(spellbook);

// playground.innerHTML = <p>Spells include: <strong>Levitation</strong> and <em>Invisibility</em>!</p>"; To replace the original HTML

//Removing Elements

const temporaryElement = document.createElement("p");
temporaryElement.textContent = "🐰 Now you see me...";
playground.append(temporaryElement);

temporaryElement.remove();

//playground.removeChild(temporaryElement); Removes special element when you working with the parent-element

const fruitBasket = document.createElement("div");
fruitBasket.innerHTML = `
<p>Apple</p>
<p>Banana</p>
<p>Cherry</p>
`;
playground.append(fruitBasket);

//while (fruitBacket.firstChild) {
//fruitBacket.removeChild(fruitBacket.firstChild);
//}

// Working with attributes

const magicWand = document.getElementById("div");
magicWand.setAttribute("id", "wand1");
magicWand.setAttribute("class", "magical-item wand");
magicWand.textContent = "🪄 Magic Wand";
playground.append(magicWand);

console.log(magicWand.getAttribute("id"));
// or console.log(magicWand.className); console.log(magicWand.id);
magicWand.id = "wand3";

console.log(magicWand.id);

//Working with Data Attributes helps to store extra info inside HTML-elment

const secretScroll = document.createElement("div");
secretScroll.id = "secretScroll";

secretScroll.dataset.spell = "invisibility";
secretScroll.dataset.components = "moonlight, shadow essence";
secretScroll.textContent = "📕 Ancient Spell Scroll";

playground.append(secretScroll);

console.log("Spell type:", secretScroll.dataset.spell);
console.log("Components:", secretScroll.dataset.components.split(","));

//Manipulating Classses

const shapeshifter = document.createElement("div");
shapeshifter.textContent = "Shapeshifter";
playground.append(shapeshifter);

shapeshifter.classList.add("magical", "creature");
console.log("Innitial classes:", shapeshifter.className);

shapeshifter.classList.remove("creature");
shapeshifter.classList.add("humanoid");

console.log("Updated classes:", shapeshifter.className);

shapeshifter.classList.toggle("invisible"); // toggle add or remove if anything is true
console.log(shapeshifter.classList.contains("invisible"));

//Useful for dynamic manipulation of elements-classes, without affecting the others
// shapeshifter.classList.toggle("invisible", Math.random() > 0.5);
//shapeshifter.classList.replace ("humanoid", "beast");
//console.log("Third class:", shapeshifter.classList.item(2));

//Inline Styles
const enchantedGem = document.createElement("div");
enchantedGem.textContent = "💎";
enchantedGem.style.fontSize = "50px";
enchantedGem.style.transition = "all 2s";
playground.append(enchantedGem);

setInterval(() => {
  enchantedGem.style.transform = `rotate(${Math.random() * 360}deg)`;
  enchantedGem.style.color = `hsl(${Math.random() * 360}, 100%, 50%)`;
}, 2000);

//Event handling
const magicButton = document.createElement("button");
magicButton.textContent = "Cast Spell";
playground.append(magicButton);

magicButton.addEventListener("click", () => {
  alert("✨ Magic sparkles fill the air!"); //Event handler or call-back function
});

magicButton.addEventListener("mouseover", (event) => {
  event.target.style.backgroundColor = "purple";
});

magicButton.addEventListener("mouseout", (event) => {
  event.target.style.backgroundColor = "";
});
