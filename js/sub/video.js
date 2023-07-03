const videoSection = document.querySelector('.videoSub');
const container = videoSection.querySelector('.container');
const goButton = videoSection.querySelector('.btnContainer button');
const btns = document.querySelectorAll('#scroll_navi li');
const btnWrap = videoSection.querySelector('.btnWrap');
const pauseBtn = videoSection.querySelector('.pauseBtn');
const playBtn = videoSection.querySelector('.playBtn ');
const videoBtnContainer = videoSection.querySelector('.videoBtnContainer ');
const vidSubTit = videoSection.querySelector('.vidSubTit');
const iframe = videoSection.querySelector('.cursorOverlay');
const vidsCloseBtn = document.querySelector('.close');
const secs = document.querySelectorAll('.myScroll');
const goTopBtn = document.querySelector('.goTopBtn');
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
  
          <div class="videoBox1" >
          <div class="videoCircle" style = "background-image : url(${json.items[idx].snippet.thumbnails.maxres.url})" data-video-id = "${
				item.snippet.resourceId.videoId
			}" data-cursor="link" data-name="Show Video">
          </div>
          <div class="textBox">
          <span class="listTitle">${tit.length > 4 ? tit.split(' ').splice(0, 4).join(' ') : tit}</span>
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
			cursor.setAttribute('style', 'top: ' + (e.pageY - 50) + 'px; left: ' + (e.pageX - 50) + 'px;');
		});

		document.addEventListener('click', (e) => {
			console.log(e.target);
			cursor.classList.add('click');

			setTimeout(() => {
				cursor.classList.remove('click');
			}, 500);
		});

		// video playlist cursor mouseover & leave
		videoCircles.forEach((videoCircle) => {
			videoCircle.addEventListener('mouseover', (e) => {
				cursorMouseOver(e);
			});

			videoCircle.addEventListener('mouseleave', (e) => {
				cursorMouseLeave(e);
			});
		});

		// imgBox1 text "click" cursor mouseover & leave
		imgBox1.addEventListener('mouseenter', (e) => {
			cursorMouseOver(e);
		});

		imgBox1.addEventListener('mouseleave', (e) => {
			cursorMouseLeave(e);
		});

		// go button cursor mouseover & leave
		goButton.addEventListener('mouseenter', (e) => {
			cursorMouseOver(e);
		});

		goButton.addEventListener('mouseleave', (e) => {
			cursorMouseLeave(e);
		});

		// button2 cursor mouseover & leave
		btnWrap.addEventListener('mouseenter', (e) => {
			cursorMouseOver(e);
		});

		btnWrap.addEventListener('mouseleave', (e) => {
			cursorMouseLeave(e);
		});

		// page Indicator mouseover cursor on & off
		btns.forEach((btn) => {
			btn.addEventListener('mouseover', (e) => {
				indicatorCursorOn(e);

				btn.addEventListener('mouseleave', (e) => {
					indicatorCursorOff(e);
				});
			});

			goTopBtn.addEventListener('mouseenter', () => {
				cursor.classList.add('hoverPageIndicator');
			});

			goTopBtn.addEventListener('mouseleave', () => {
				cursor.classList.remove('hoverPageIndicator');
			});
		});

		// 페이지 스크롤 mouseover 함수
		function indicatorCursorOn(e) {
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hoverPageIndicator');
			cursor.innerText = dataName;
		}

		// 페이지 스크롤 mouseleave 함수
		function indicatorCursorOff(e) {
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.remove('hoverPageIndicator');
			cursor.innerText = dataName;
		}

		// 커서 "text" mouseover effect 함수
		function cursorMouseOver(e) {
			const dataName = e.target.getAttribute('data-name');
			cursor.classList.add('hover');
			cursor.innerText = dataName;
		}

		// 커서 "text" mouseleave effect 함수
		function cursorMouseLeave(e) {
			cursor.innerText = '';
			cursor.classList.remove('hover');
		}
	});

//subtitle 동영상 재생 멈춤 기능
let count = 0;

videoBtnContainer.addEventListener('click', () => {
	count += 1;

	if (count % 2 !== 0) {
		videoOn(pauseBtn, playBtn, vidSubTit);
	} else {
		videoOff(pauseBtn, playBtn, vidSubTit);
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
		videoOn(pauseBtn2, playBtn2, vidImgBox);
	} else {
		videoOff(pauseBtn2, playBtn2, vidImgBox);
	}
});

//동영상 버튼 멈춤 함수
function videoOn(el1, el2, el3) {
	el1.style.display = 'none';
	el2.style.display = 'block';
	el3.pause();
}

//동영상 버튼 재생 함수
function videoOff(el1, el2, el3) {
	el1.style.display = 'block';
	el2.style.display = 'none';
	el3.play();
}

//imgBox 클릭하면 순서보여주는 기능
const result = videoSection.querySelector('#result');
const imgBox1 = videoSection.querySelector('.imgBox1');
const changeImg = videoSection.querySelector('.changeImg');

const imgBoxGroups = ['imgBoxGroup1.png', 'imgBoxGroup2.png', 'imgBoxGroup3.png', 'imgBoxGroup4.png', 'imgBoxGroup5.png'];

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
	if (e.target.className === 'videoCircle') createPop(e.target.closest('.videoCircle').getAttribute('data-video-id'));

	if (e.target.className === 'close1' || e.target.closest('.close1')) removePop();
});

//vids 동적으로 팝업 생성
function createPop(id) {
	const tags = `	
			<div class='con'>
			<iframe src='https://www.youtube.com/embed/${id}'></iframe></div>
			<span class='close1'><i class="fa-solid fa-xmark"></i></span>
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

//팝업제거
function removePop() {
	document.querySelector('.pop').classList.remove('on');
	setTimeout(() => document.querySelector('.pop').remove(), 1000);
	document.body.style.overflow = 'auto';
	document.body.style.overflowX = 'hidden';
}
