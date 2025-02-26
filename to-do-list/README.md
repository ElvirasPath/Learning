## Mini Project: To-Do List Application
Now, try creating a simple To-Do List application using what you've learned.

### Steps to Follow:
1. **Set Up Your Project**
   - Create a new branch for the to-do list project.
   - Make a new folder for the project and navigate into it.
   - Add `index.html`, `style.css`, and `script.js` files.

2. **Build the HTML Structure**
   - Create an input field where users can type a task.
   - Add a button to add tasks to the list.
   - Include an empty list (`<ul>` or `<ol>`) where tasks will be displayed.

   *Hint: Use `<input>` for task entry, `<button>` to add tasks, and `<ul>` for the list.*

3. **Style Your Application**
   - Use CSS to make the to-do list visually appealing.
   - Style the input field, button, and list items for a clean UI.

   *Hint: You can use `border-radius` for rounded corners and `box-shadow` for a slight elevation effect.*

4. **Implement Functionality with JavaScript**
   - Write a function to capture input from the user when they click the add button.
   - Append the new task to the list dynamically.
   - Add functionality to remove a task when it's completed.

   *Hint: Use `document.querySelector()` to access elements and `appendChild()` to add list items.*
   
   Example snippet:
   ```js
   document.getElementById("addButton").addEventListener("click", function() {
       let task = document.getElementById("taskInput").value;
       if (task) {
           let li = document.createElement("li");
           li.textContent = task;
           document.getElementById("taskList").appendChild(li);
       }
   });
   ```

5. **Test Your Application**
   - Open `index.html` in a browser and test adding and removing tasks.
   - Fix any bugs you encounter.

6. **Commit and Push Your Changes**
   - Add and commit your files.
   - Push your branch to GitHub and create a pull request.

7. **Merge Your Work**
   - After review, merge the branch into the main branch.
   - Switch back to main and pull the latest changes.
