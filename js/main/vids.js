//vids
const vidsSection = document.querySelector('#vids');
const vidsVideoWrap = vidsSection.querySelector('.vidsVideoWrap');
const key = 'AIzaSyCKs11Yu98hp6fq7N54tY2iWSY9qvTh4cM';
const list = 'PLWgHnOZUp_4H3oyXBnWAhhQhWulLsuoPO';

let videoIsOn;

let num;

resizeVids(5);

// 화면 줄이면 보이는 동영상 갯수 설정
window.addEventListener('resize', function () {
	console.log('resize event!');

	if (window.innerWidth >= 1024 && window.innerWidth <= 1920) {
		num = 5;
		resizeVids(num);
		console.log(num);
	} else if (window.innerWidth >= 639 && window.innerWidth <= 1023) {
		num = 3;
		resizeVids(num);
		console.log(num);
	} else if (window.innerWidth < 638) {
		num = 2;
		resizeVids(num);
		console.log(num);
	}
});

function resizeVids(num) {
	const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;
	fetch(url)
		.then((data) => data.json())
		.then((json) => {
			console.log(json.items);
			let tags = '';

			json.items.forEach((item, idx) => {
				let tit = item.snippet.title;
				let desc = item.snippet.description;

				tags += `
			<div class="video ${idx === 0 ? 'on' : ''}" data-video-id = "${item.snippet.resourceId.videoId}"
				style = "background-image : url(${json.items[idx].snippet.thumbnails.maxres.url})">
				<div class="vidsNum">${item.snippet.position + 1}</div>
				<div class="vidsBarTit">${(tit.length > 15 ? tit.substr(0, 20) : tit) + '...'}</div>

				<span class="vidsOnSpan" style ="display: none">
					<h4>${(item.snippet.position + 1).toString().padStart(2, 0)}.</h4>
					<h2>${(tit.length > 50 ? tit.substr(0, 50) : tit) + '...'}</h2>
					<p>${(desc.length > 50 ? desc.substr(0, 250) : desc) + '...'}</p>
				</span>
					<button class="discoverBtn" style ="display: none">Discover Now</button>
			</div>
			`;
			});

			vidsVideoWrap.innerHTML = tags;

			const videos = vidsSection.querySelectorAll('.video');
			const vidsNum = vidsSection.querySelectorAll('.vidsNum');
			const vidsBarTit = vidsSection.querySelectorAll('.vidsBarTit');
			const vidsSpan = vidsSection.querySelectorAll('.vidsOnSpan');
			const discoverBtn = vidsSection.querySelectorAll('.discoverBtn');

			// box클릭하면 해당 box열리는 기본 기능
			videos.forEach((video, idx) => {
				if (videos[idx].classList.contains('on')) {
					vidsNum[idx].style.display = 'none';
					vidsBarTit[idx].style.display = 'none';
					videos[
						idx
					].style.backgroundImage = `url(${json.items[idx].snippet.thumbnails.maxres.url})`;
					vidsSpan[idx].style.display = 'block';
					discoverBtn[idx].style.display = 'block';
				}

				video.addEventListener('click', (e) => {
					e.preventDefault();

					for (const video of videos) video.classList.remove('on');
					videos[idx].classList.add('on');

					videos[idx].classList.contains('on')
						? ((vidsNum[idx].style.display = 'none'),
						  (vidsBarTit[idx].style.display = 'none'),
						  ((videos[
								idx
						  ].style.backgroundImage = `url(${json.items[idx].snippet.thumbnails.maxres.url})`),
						  (vidsSpan[idx].style.display = 'block')),
						  (discoverBtn[idx].style.display = 'block'))
						: ((vidsNum[idx].style.display = 'block'),
						  (vidsBarTit[idx].style.display = 'block'),
						  (vidsSpan[idx].style.display = 'none'),
						  (discoverBtn[idx].style.display = 'none'));

					for (let i = 0; i < videos.length; i++) {
						if (!videos[i].classList.contains('on')) {
							vidsBarTit[i].style.display = 'block';
							vidsNum[i].style.display = 'block';
							vidsSpan[i].style.display = 'none';
							discoverBtn[i].style.display = 'none';
						}
					}
				});
			});
		});
}

//vids pop 찹업창 띄우기
document.body.addEventListener('click', (e) => {
	if (e.target.className === 'discoverBtn')
		createPop(e.target.closest('.video').getAttribute('data-video-id'));
	if (e.target.className === 'close') removePop();
});

//vids 동적으로 팝업 생성
function createPop(id) {
	const tags = `	
			<div class='con'>
			<iframe src='https://www.youtube.com/embed/${id}'></iframe></div>
			<span class='close'>x</span>
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
