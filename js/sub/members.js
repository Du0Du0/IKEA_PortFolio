const membersSection = document.querySelector('.members');
const memberBoxContainer = membersSection.querySelector('.memberBoxContainer');

let tags = '';

fetch('DB/members.json')
	.then((res) => res.json())
	.then((json) => {
		console.log(json.item);
		const membersData = json.members;

		membersData.map((data) => {
			tags += `
       <div class="membersBox">
       <div class="membersName"><h1>${data.name}</h1><h3>${data.sub}</h3></div>
        <div class="membersImg" style="background-image : url(img/${data.pic})"><div class="colorBg">1</div></div>
        <div class="membersDesc"><p>${data.description}</p></div>

     </div>
      `;
		});
		memberBoxContainer.innerHTML = tags;
	});
