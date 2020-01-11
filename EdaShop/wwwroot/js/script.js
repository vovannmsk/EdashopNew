(function($) {
	var limit;
  $(document).ready(function() {
	limit = $('#catalog-menu').position().top;
	MenuScroll();
	//----
	if ($('body').width() >= 720) {
		var item265 = $('#catalog-menu ul li.item-265 a').text();
		item265 = item265.replace('&','\<br \/\> \& \<br \/\>');
		$('#catalog-menu ul li.item-265 a').html(item265);
		var item177 = $('#catalog-menu ul li.item-177 a').text();
		item177 = item177.replace('&','\<br \/\> \& \<br \/\>');
		$('#catalog-menu ul li.item-177 a').html(item177);
		var item184 = $('#catalog-menu ul li.item-184 a').text();
		item184 = item184.replace('&','\<br \/\> \& \<br \/\>');
		$('#catalog-menu ul li.item-184 a').html(item184);
	}else{
		$('select.cm-mobile').on('change',function(){
			$(this).val()&&""!=$(this).val()&&(window.location=$(this).val())
		});
		if($('#catalog-menu ul.menu li.item-149').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-149').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-264').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-264').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-265').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-265').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-266').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-266').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-177').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-177').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-184').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-184').prop('selected', true);
		}else if($('#catalog-menu ul.menu li.item-180').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-180').prop('selected', true);
		}else if($('#main-menu ul.menu li.item-101').hasClass('active')){
			$('#catalog-menu select.cm-mobile option.item-101').prop('selected', true);
		}
	}
	//----
	$('.ptcat1:first').before('<h2 id="ptcat1">Суши</h2><hr />');
	$('.ptcat1').wrapAll($('<div class="row"></div>'));
	$('.ptcat2:first').before('<h2 id="ptcat2">Спайс суши</h2><hr />');
	$('.ptcat2').wrapAll($('<div class="row"></div>'));
	$('.ptcat3:first').before('<h2 id="ptcat3">Роллы</h2><hr />');
	$('.ptcat3').wrapAll($('<div class="row"></div>'));
	$('.ptcat4:first').before('<h2 id="ptcat4">Я люблю Филадельфию</h2><hr />');
	$('.ptcat4').wrapAll($('<div class="row"></div>'));
	$('.ptcat5:first').before('<h2 id="ptcat5">Запечённые роллы</h2><hr />');
	$('.ptcat5').wrapAll($('<div class="row"></div>'));
	$('.ptcat6:first').before('<h2 id="ptcat6">Горячие роллы</h2><hr />');
	$('.ptcat6').wrapAll($('<div class="row"></div>'));
	$('.ptcat7:first').before('<h2 id="ptcat7">Классические роллы</h2><hr />');
	$('.ptcat7').wrapAll($('<div class="row"></div>'));
	$('.ptcat8:first').before('<h2 id="ptcat8">Ассорти</h2><hr />');
	$('.ptcat8').wrapAll($('<div class="row"></div>'));
	$('.ptcat9:first').before('<h2 id="ptcat9">Wok (Вок)</h2><hr />');
	$('.ptcat9').wrapAll($('<div class="row"></div>'));
	$('.ptcat10:first').before('<h2 id="ptcat10">Супы</h2><hr />');
	$('.ptcat10').wrapAll($('<div class="row"></div>'));
	$('.ptcat11:first').before('<h2 id="ptcat11">Салаты</h2><hr />');
	$('.ptcat11').wrapAll($('<div class="row"></div>'));
	$('.ptcat12:first').before('<h2 id="ptcat12">Десерты</h2><hr />');
	$('.ptcat12').wrapAll($('<div class="row"></div>'));
	$('.ptcat13:first').before('<h2 id="ptcat13">Напитки</h2><hr />');
	$('.ptcat13').wrapAll($('<div class="row"></div>'));
	//----
	$('#catalog-menu a[href^="#"]').on('click', function(){
		var target = $(this).attr('href');
		$('html, body').animate({scrollTop: $(target).offset().top - 150}, 1000);
	return false;
	});
	//---- tabs
	$(function(){$('#tabs-launch').tabs();});
	$(function(){$('#tabs').tabs();});
	//---- fancybox
	$('a.video').fancybox();
	$('a.modal').fancybox();
	//---- menu mobile
	if ($('body').width() < 1000) {
		$('.mm-icon').click(function(){
			if($('#mobile-menu').hasClass('active')){
				$('#mobile-menu').removeClass('active');
				$('.mm-shadow').removeClass('active');
				$('#mobile-menu').animate({right:'-245px'},1000);
				return false
			}else{
				$('#mobile-menu').addClass('active');
				$('.mm-shadow').addClass('active');
				$('#mobile-menu').animate({right:'0'},1000);
				return false
			}
		});
		$('#mobile-menu ul li a').click(function(){
			if($('#mobile-menu').hasClass('active')){
				$('#mobile-menu').removeClass('active');
				$('.mm-shadow').removeClass('active');
				$('#mobile-menu').animate({right:'-245px'},1000);
			}
		});
		$('.mm-shadow').click(function(){
			if($('#mobile-menu').hasClass('active')){
				$('#mobile-menu').removeClass('active');
				$('.mm-shadow').removeClass('active');
				$('#mobile-menu').animate({right:'-245px'},1000);
			}
		});
	}
	
  });
  $(document).scroll(function(){MenuScroll();});
  var MenuScroll = function(){
	var top = $(document).scrollTop();    
	var bottom = $(document).height() - $(window).height() - $('#footer').height();
	if ($(document).height() <= 1350 || $('#content').height() <= 1000){
	}else{
		if (top >= limit) {
		  $('#catalog-menu').css('position', 'fixed').css('top', '0'); 
		}else{
		  $('#catalog-menu').css('position', 'relative').css('top', '');
		}
		if (top >= bottom) {
		  $('#catalog-menu').css('top', bottom-top);//-$('#footer').height()
		}else{
		  $('#catalog-menu').removeAttr('top');
		}
	}
  };
})(jQuery);
