/*File Name: tableMod.js 
Date: 10/19/2017
Programmer: Rochelle Simpson*/

$(document).ready(function(){
	$('#char-roster').dataTable({
		'sPaginationType': 'full_numbers',
		'bJQueryUI': true,
		'bFilter': true,
	});
});
