//using viewer.js file from extenstion-getting-started as a template
// let token = '';
// let uid = '';

// const twitch = window.Twitch.ext;

// const requests = {
//     // set: createRequest_NumKilled('POST', 'numkilled'),
//     // set: createRequest_NumNotKilled('POST', 'numnotkilled'),
//     // set: createRequest_HPMonster('POST', 'hpmonster'),
    
//     // get: createRequest_NumKilled('GET', 'query')

//     set: createReq('POST', 'info'),
//     get: createReq('GET', 'query')
// }

// function createReq(type, method) {
//   return {
//     type: type,
//     url: location.protocol + '//localhost:8081/' + method,
//     success: grabInfo,
//     error: errorLog
//   };
// }

// function createRequest_NumKilled (type, method) {
//     return {
//       type: type,
//       url: location.protocol + '//localhost:8081/' + method,
//       success: grabNumKilled_Info,
//       error: errorLog
//     };
//   }

// function createRequest_NumNotKilled (type, method) {
//     return {
//       type: type,
//       url: location.protocol + '//localhost:8081/' + method,
//       success: grabNumNotKilled_Info,
//       error: errorLog
//     };
//   }

// function createRequest_HPMonster (type, method) {
//     return {
//       type: type,
//       url: location.protocol + '//localhost:8081/' + method,
//       success: grabHPMonster_Info,
//       error: errorLog
//     };
//   }

  // copied from https://dev.twitch.tv/docs/tutorials/extension-101-tutorial-series/config-service#step-1-config-view-logic
  // changed according to variables and context of this project
  //may change
  function showInfo() {

    var items = []
      $("input[name='items[]']:checked").each(function ()
      {
          items.push($(this).val() + " ");

      });
      console.log(items);
      $('#result').html(items);
    }
    
  showInfo();
    
  $('div').delegate('input:checkbox', 'click', showInfo);



// function showInfo() {

//   var items = $.map($('input:checkbox:checked'), function(e, i) {
//       return +e.value;
//   });

//   $('span').text('The information being tracked is: ' + items.join(','));
// }

// showInfo();

// $('div').delegate('input:checkbox', 'click', showInfo);


// function updateConf() {
//   // writes the items saved into the array into configuration service
//   twitch.configuration.set("broadcaster", "0.0.1", JSON.stringify(items));
//   twitch.rig.log('Grabbing information needed...')
// }

// // copied from https://dev.twitch.tv/docs/tutorials/extension-101-tutorial-series/config-service
// twitch.configuration.onChanged(function() {
//   // if conf is defined
//   if (twitch.configuration.broadcaster) {
//     try {
//       var conf = JSON.parse(twitch.configuration.broadcaster.content)

//       if (typeof config === "object") {
//         items = config
//         grabInfo()
//       } else {
//         console.log('error 1')
//       }
//     } catch (e) {
//       console.log('error 2')
//     }
//   }
// })


// function errorLog(_, error, status) {
//   twitch.rig.log('Error: '+status+' ('+error+')');
// }


// // both sections are from viewer.js file from extenstion-getting-started
// twitch.onContext(function (context) {
//     twitch.rig.log(context);
//   });

// twitch.onAuthorized(function (auth) {
//     // save our credentials
//     token = auth.token;
//     uid = auth.userId;
//   });