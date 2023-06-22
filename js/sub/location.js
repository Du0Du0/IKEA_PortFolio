const mapContainer = document.querySelector('#map');
const btns = document.querySelectorAll('.rightContainer .list');

const icon = document.querySelector('.svgBox path');
const icon_len = 2730;

const baseline = -window.innerHeight / 2;

window.addEventListener('scroll', () => {
	const scroll = window.scrollY;
	//해당 섹션 영역에 도달했을때 다시 0으로 보정된 스크롤값
	let scroll2 = (scroll - secs[2].offsetTop - baseline) * 5;

	//해당 섹션에 스크롤이 도달하면
	if (scroll > secs[2].offsetTop + baseline) {
		//아이콘의 strokeDashoffset값을 보정된 scroll2값으로 계속 뺴줌 (선이 그어지기 시작함)
		icon.style.strokeDashoffset = icon_len - scroll2;
		//scroll2값이 만약에 전체 선의 길이를 넘어가는 순간 값을 0으로 강제고정
		//이렇게 하지 않으면 다시 반대방향으로 선이 빠지게됨
		scroll2 >= icon_len && (scroll2 = icon_len);
	} else {
		//해당 섹션에서 스크롤이 벗어나게 되면 다시 strokeDashoffset값을 원래 고정해서 초기화
		icon.style.strokeDashoffset = icon_len;
	}
});

let active_index = 0;

const markerInfo = [
	{
		title: 'IKEA 고양점',
		position: new kakao.maps.LatLng(37.62986119395948, 126.8631475894335),
		imgSrc: 'img/marker1.png',
		imgSize: new kakao.maps.Size(110, 100),
		imgPos: { offset: new kakao.maps.Point(56, 80) },
		content:
			'<div class="customoverlay">' +
			'  <a href="https://map.kakao.com/link/map/11394059" target="_blank">' +
			'    <span class="title">구의야구공원</span>' +
			'  </a>' +
			'</div>',
		button: btns[0],
	},
	{
		title: 'IKEA 기흥점',
		position: new kakao.maps.LatLng(37.22224126621655, 127.11567913939837),
		imgSrc: 'img/marker1.png',
		imgSize: new kakao.maps.Size(110, 100),
		imgPos: { offset: new kakao.maps.Point(54, 90) },
		button: btns[1],
	},
	{
		title: 'IKEA 광명점',
		position: new kakao.maps.LatLng(37.42432343572819, 126.88286963577373),
		imgSrc: 'img/marker1.png',
		imgSize: new kakao.maps.Size(110, 100),
		imgPos: { offset: new kakao.maps.Point(55, 90) },
		button: btns[2],
	},
	{
		title: 'IKEA 동부산점',
		position: new kakao.maps.LatLng(35.19079483522182, 129.210473742942),
		imgSrc: 'img/marker1.png',
		imgSize: new kakao.maps.Size(110, 100),
		imgPos: { offset: new kakao.maps.Point(54, 90) },
		button: btns[3],
	},
];

//markerInfo의 첫번째 데이터로 기본 지도 인스턴스 생성
const map = new kakao.maps.Map(mapContainer, { center: markerInfo[0].position, level: 3 });
//마우스휠 이벤트시 줌 기능 비활성화
map.setZoomable(false);

//맵타입 인스턴스 생성후 맵인스턴스에 바인딩
const mapTypeControl = new kakao.maps.MapTypeControl();
map.addControl(mapTypeControl, kakao.maps.ControlPosition.TOPLEFT);

//맵줌컨트롤 인스턴스 생성후 맵인스턴스에 바인딩
const zoomControl = new kakao.maps.ZoomControl();
map.addControl(zoomControl, kakao.maps.ControlPosition.LEFT);

//markerInfo배열 데이터를 통해 기존 맵인스턴스에 반복을 돌며 마커 생성하고 바인딩
markerInfo.forEach((info, idx) => {
	const marker = new kakao.maps.Marker({
		position: info.position,
		image: new kakao.maps.MarkerImage(info.imgSrc, info.imgSize, info.imgPos, info.content),
	});
	marker.setMap(map);

	//지점 버튼을 클릭시
	info.button.addEventListener('click', () => {
		//현재 클릭한 버튼의 순번을 active_index전역변수에 옮겨담음
		//추후 브라우저 리사이즈시 현재 활성화 된 지역위치의 데이터 순번이 필요하기 때문
		active_index = idx;
		map.panTo(info.position);

		for (const el of btns) el.classList.remove('on');
		btns[idx].classList.add('on');
	});
});

//브라우저 리사이즈시 지도 위치 및 마커 가운데 보정
window.addEventListener('resize', () => {
	//현재 활성화 되어 있는 순번의 지역위치값으로 맵 인스턴스 가운데 위치보정
	map.setCenter(markerInfo[active_index].position);
});

//위의 정보로 최종 마커이미지 인스턴스 생성
const markerImage = new kakao.maps.MarkerImage(imageSrc, imageSize, imageOption);

//해당 이미지 인스턴스를 마커생성하는 구문에 추가
const marker = new kakao.maps.Marker({ position: position, image: markerImage }); //마커 인스턴스 생성

marker.setMap(map);
