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
  
          <div class="viedoBox1" >
          <div class="videoCircle" style = "background-image : url(${
						json.items[idx].snippet.thumbnails.maxres.url
					})" data-video-id = "${
				item.snippet.resourceId.videoId
			}" data-cursor="link" data-name="Show Video">
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

		const videoCircles = document.querySelectorAll('.videoCircle');

		// 커스텀 마우스 커서

		const cursor = document.querySelector('.cursor');
		document.addEventListener('mousemove', (e) => {
			cursor.setAttribute(
				'style',
				'top: ' + (e.pageY - 60) + 'px; left: ' + (e.pageX - 60) + 'px;'
			);
		});

		document.addEventListener('click', (e) => {
			console.log(e.target);
			cursor.classList.add('click');

			setTimeout(() => {
				cursor.classList.remove('click');
			}, 500);
		});

		videoCircles.forEach((videoCircle) => {
			videoCircle.addEventListener('mouseover', (e) => {
				console.log('아놔');
				const dataName = e.target.getAttribute('data-name');
				cursor.classList.add('hover');
				cursor.innerText = dataName;
			});
		});

		videoCircles.forEach((videoCircle) => {
			videoCircle.addEventListener('mouseleave', (e) => {
				console.log('아놔');
				cursor.innerText = '';
				cursor.classList.remove('hover');
			});
		});

		const iframe = document.querySelector('.cursorOverlay');
		iframe.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		iframe.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});

		const imgBox1 = document.querySelector('.imgBox1');
		imgBox1.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		imgBox1.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});
		const goButton = document.querySelector('.btnContainer button');
		goButton.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		goButton.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});

		const btnWrap = document.querySelector('.btnWrap');
		btnWrap.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		btnWrap.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});

		const vidSubTit = document.querySelector('.vidSubTit');
		vidSubTit.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		vidSubTit.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});

		const vidImgBox = document.querySelector('.vidImgBox');
		vidImgBox.addEventListener('mouseenter', (e) => {
			console.log('아놔3');
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		});

		vidImgBox.addEventListener('mouseleave', (e) => {
			console.log('아놔');
			cursor.innerText = '';
			cursor.classList.remove('hover');
		});

		const btns = document.querySelectorAll('#scroll_navi li');
		btns.forEach((btn) => {
			btn.addEventListener('mouseover', (e) => {
				console.log('아놔3');
				const dataName = e.target.getAttribute('data-name');
				cursor.classList.add('hoverPageIndicator');
				cursor.innerText = dataName;
			});

			// Go Top Button
			const goTopBtn = document.querySelector('.goTopBtn');

			goTopBtn.addEventListener('click', () => {
				window.scrollTo({ top: 0, left: 0, behavior: 'smooth' });
			});

			goTopBtn.addEventListener('mouseenter', () => {
				cursor.classList.add('hoverPageIndicator');
			});

			goTopBtn.addEventListener('mouseleave', () => {
				cursor.classList.remove('hoverPageIndicator');
			});
		});

		btns.forEach((btn) => {
			btn.addEventListener('mouseleave', (e) => {
				console.log('아놔3');
				const dataName = e.target.getAttribute('data-name');
				cursor.classList.remove('hoverPageIndicator');
				cursor.innerText = dataName;
			});
		});
	});

//subtitle 동영상 재생 멈춤 기능

const pauseBtn = videoSection.querySelector('.pauseBtn');

const playBtn = videoSection.querySelector('.playBtn ');

const videoBtnContainer = videoSection.querySelector('.videoBtnContainer ');

const vidSubTit = videoSection.querySelector('.vidSubTit');

let count = 0;

videoBtnContainer.addEventListener('click', () => {
	count += 1;

	if (count % 2 !== 0) {
		pauseBtn.style.display = 'none';
		playBtn.style.display = 'block';
		vidSubTit.pause();
	} else {
		pauseBtn.style.display = 'block';
		playBtn.style.display = 'none';
		vidSubTit.play();
	}
});

//imgBox 동영상 재생 멈춤 기능

const pauseBtn2 = videoSection.querySelector('.pauseBtn2');

const playBtn2 = videoSection.querySelector('.playBtn2 ');

const videoBtnContainer2 = videoSection.querySelector('.videoBtnContainer2 ');

const vidImgBox = videoSection.querySelector('.vidImgBox');

let click = 0;

videoBtnContainer2.addEventListener('click', () => {
	count += 1;

	if (count % 2 !== 0) {
		pauseBtn2.style.display = 'none';
		playBtn2.style.display = 'block';
		vidImgBox.pause();
	} else {
		pauseBtn2.style.display = 'block';
		playBtn2.style.display = 'none';
		vidImgBox.play();
	}
});

//imgBox 클릭하면 순서보여주는 기능
const result = videoSection.querySelector('#result');

const imgBox1 = videoSection.querySelector('.imgBox1');

const changeImg = videoSection.querySelector('.changeImg');

const imgBoxGroups = [
	'imgBoxGroup1.png', //0
	'imgBoxGroup2.png', //1
	'imgBoxGroup3.png', //2
	'imgBoxGroup4.png', //3
	'imgBoxGroup5.png', //4
];

let currentidx = -1;

imgBox1.addEventListener('click', () => {
	currentidx += 1;

	result.innerHTML = currentidx + 1;

	changeImg.src = `img/${imgBoxGroups[currentidx]}`;

	if (currentidx > imgBoxGroups.length - 2) {
		currentidx = -1;
	} else return;
});

//vids pop 찹업창 띄우기
document.body.addEventListener('click', (e) => {
	if (e.target.className === 'videoCircle')
		createPop(e.target.closest('.videoCircle').getAttribute('data-video-id'));
	if (e.target.className === 'close') removePop();
});

//vids 동적으로 팝업 생성
function createPop(id) {
	const tags = `	
			<div class='con'>
			<iframe src='https://www.youtube.com/embed/${id}'></iframe></div>
			<span class='close'><i class="fa-solid fa-xmark"></i></span>
	`;
	const pop = document.createElement('aside');
	pop.className = 'pop';
	pop.innerHTML = tags;
	document.body.append(pop);
	console.log('.pop');

	//특정 코드를 강제로 동기화시키고 싶을때는 setTimeout에 delay를 0초로 지정해서 코드를 패키징 (강제로 wep api에 넘어갔다가 다시 콜스택 젤 마지막에 등록)
	setTimeout(() => document.querySelector('.pop').classList.add('on'), 0);
	document.body.style.overflow = 'hidden';
}

const vidsCloseBtn = document.querySelector('.close');

//팝업제거
function removePop() {
	document.querySelector('.pop').classList.remove('on');
	setTimeout(() => document.querySelector('.pop').remove(), 1000);
	document.body.style.overflow = 'auto';
}
