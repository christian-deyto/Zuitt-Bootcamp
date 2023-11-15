// console.log("Hello Sahod!");


// Get post data


fetch("https://jsonplaceholder.typicode.com/posts")
.then((response) => response.json())
.then((data) => 

	// console.log(data)

	showPosts(data)
);



// console.log(document);
// console.log(document.querySelector("#form-add-post"));


// Add Post data
document.querySelector("#form-add-post").addEventListener('submit', (e) => {

	// prevents the default behavior of html elements like the form element.
	e.preventDefault();


	// Here we will submit a post request to the Post collection in the API/DB.
	fetch("https://jsonplaceholder.typicode.com/posts", {
		method: "POST",
		body: JSON.stringify({
			title: document.querySelector("#txt-title").value,
			body: document.querySelector("#txt-body").value,
			userId: 1
		}),
		headers: {
			'Content-Type': 'application/json'
		}
	})
	.then((response) => response.json())
	.then((data) => {
		// Post object created
		console.log(data);

		// Response message to user
		alert("Post added successfully!")


		// Clear the form for the next user.
		document.querySelector("#txt-title").value = null;
		document.querySelector("#txt-body").value = null;

	})

});


// Show post function - to display all the post from our API/DB.

const showPosts = (posts) => {
	let postEntries = '';


	posts.forEach((post) => {
		postEntries += `
			<div id="post-${post.id}">
				<h3 id="post-title-${post.id}">${post.title}</h3>
				<p id="post-body-${post.id}">${post.body}</p>
				<button onclick="editPost(${post.id})">Edit</button>
				<button onclick="deletePost(${post.id})">Delete</button>
			</div>
		`;
	});

	document.querySelector("#div-post-entries").innerHTML = postEntries;

};



// Edit Post. This function will add the id passed from the Edit button and the details from the post to be edited.

const editPost = (id) => {

	// here we took the information from each of the post entries.
	let title = document.querySelector(`#post-title-${id}`).innerHTML;
	let body = document.querySelector(`#post-body-${id}`).innerHTML;

	// here we pass the info from the post entries to the value property of each input field / element

	document.querySelector('#txt-edit-id').value = id;
	document.querySelector('#txt-edit-title').value = title;
	document.querySelector('#txt-edit-body').value = body;

	document.querySelector('#btn-submit-update').removeAttribute('disabled');

};


// Update Post. This function will run when the edit form is submitter.

document.querySelector("#form-edit-post").addEventListener('submit', (e) => {

	e.preventDefault();

	fetch("https://jsonplaceholder.typicode.com/posts/100", {
		method: "PUT",
		body: JSON.stringify({
			id: document.querySelector("#txt-edit-id").value,
			title: document.querySelector("#txt-edit-title").value,
			body: document.querySelector("#txt-edit-body").value,
			userId: 1
		}),
		headers: {
			'Content-Type': 'application/json'
		}
	})
	.then((response) => response.json())
	.then((data) => {
		console.log(data);
		alert("Post successfully updated.");

		document.querySelector("#txt-edit-id").value = null;
		document.querySelector("#txt-edit-title").value = null;
		document.querySelector("#txt-edit-body").value = null;
		document.querySelector("#btn-submit-update").setAttribute('disabled', true);

	})

});



// Guided Activity

// Delete post function
const deletePost = (id) => {
	fetch(`https://jsonplaceholder.typicode.com/posts`, {method: "DELETE"});

	let deletedPost = document.querySelector(`#post-${id}`)

	document.querySelector(`#post-${id}`).remove()
	
	console.log(deletedPost);	
};




// Delete All Post
document.querySelector("#delete-all").addEventListener('click', () => {
	document.querySelector("#div-post-entries").innerHTML = "";
	alert("All Posts Deleted");
});
