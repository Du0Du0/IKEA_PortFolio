const notice = document.querySelector('#notice');
const noticeWrap = document.querySelectorAll('.noticeWrap')[1];

let tags = '';

fetch('DB/notice.json')
	.then((res) => res.json())
	.then((data) => {
		const noticeData = data.notice;

		noticeData.map((data) => {
			const tit = data.title;
			const con = data.content;
			tags += `
      <div class="contentWrap">
          <div class="topic">
            <p>${data.topic}</p>
          </div>
          <div class="titleWrap">
            <h2>${tit.length > 6 ? tit.split(' ').splice(0, 6).join(' ') : tit}</h2>
            <p>${data.date}</p>
          </div>
          <div class="content">
            <p>${con.length > 23 ? con.split(' ').splice(0, 23).join(' ') : con}</p>
          </div>
        </div>
        `;
		});
		noticeWrap.innerHTML = tags;
	})
	.catch((err) => {
		console.log(err);
	});
