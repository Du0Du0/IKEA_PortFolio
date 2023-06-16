const videoSection = document.querySelector('.video');
const container = videoSection.querySelector('.container');
const key = 'AIzaSyCKs11Yu98hp6fq7N54tY2iWSY9qvTh4cM';
const list = 'PLWgHnOZUp_4FJWdMzYeEAM4Waf8IhnZCB';
const num = 8;

const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;

fetch(url)
	.then((data) => data.json())
	.then((json) => {
		console.log(json.items);
		let tags = '';

		json.items.forEach((item, idx) => {
			let tit = item.snippet.title;

			tags += `
  
          <div class="viedoBox1">
          <div class="videoCircle" style = "background-image : url(${
						json.items[idx].snippet.thumbnails.maxres.url
					})">
          </div>
          <div class="textBox">
          <span class="listTitle">${
						tit.length > 4 ? tit.split(' ').splice(0, 4).join(' ') : tit
					}</span>
            <p>${item.snippet.publishedAt.substr(0, 10)}</p>
          </div>
      </div>
  
  `;
		});
		container.innerHTML = tags;
	});
