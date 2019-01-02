/*
Error: Invalid CSS after "font-family:": expected pseudoclass or pseudoelement, was "'Poppins', sans..."
        on line 3 of src/sass/style.sass

1: li 
2:     a
3:     font-family:'Poppins', sans-serif

Backtrace:
src/sass/style.sass:3
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/parser.rb:1308:in `expected'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/parser.rb:1238:in `expected'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/parser.rb:1233:in `tok!'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/parser.rb:1097:in `ident!'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/static_parser.rb:282:in `pseudo'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/static_parser.rb:163:in `simple_selector_sequence'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/static_parser.rb:108:in `selector'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/static_parser.rb:83:in `selector_comma_sequence'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/parser.rb:1216:in `expr!'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/scss/static_parser.rb:20:in `parse_selector'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:434:in `visit_rule'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:36:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:79:in `block in with_base'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:135:in `with_frame'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:79:in `with_base'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:158:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:440:in `block (2 levels) in visit_rule'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:440:in `map'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:440:in `block in visit_rule'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:179:in `with_environment'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:438:in `visit_rule'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:36:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:79:in `block in with_base'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:135:in `with_frame'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/stack.rb:79:in `with_base'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:158:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:52:in `block in visit_children'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:52:in `map'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:52:in `visit_children'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:167:in `block in visit_children'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:179:in `with_environment'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:166:in `visit_children'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:36:in `block in visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:186:in `visit_root'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/base.rb:36:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:157:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/visitors/perform.rb:10:in `visit'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/root_node.rb:36:in `css_tree'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/tree/root_node.rb:29:in `render_with_sourcemap'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/engine.rb:389:in `_render_with_sourcemap'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/engine.rb:307:in `render_with_sourcemap'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:462:in `update_stylesheet'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:215:in `block in update_stylesheets'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:209:in `each'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:209:in `update_stylesheets'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:443:in `on_file_changed'
/var/lib/gems/2.5.0/gems/sass-3.7.2/lib/sass/plugin/compiler.rb:320:in `block in watch'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/config.rb:23:in `call'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/processor.rb:115:in `_process_changes'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/processor.rb:19:in `block in loop_for'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/processor.rb:15:in `loop'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/processor.rb:15:in `loop_for'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/loop.rb:84:in `_wait_for_changes'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/event/loop.rb:42:in `block in setup'
/var/lib/gems/2.5.0/gems/sass-listen-4.0.0/lib/sass-listen/internals/thread_pool.rb:6:in `block in add'
*/
body:before {
  white-space: pre;
  font-family: monospace;
  content: "Error: Invalid CSS after \"font-family:\": expected pseudoclass or pseudoelement, was \"'Poppins', sans...\"\A         on line 3 of src/sass/style.sass\A \A 1: li \A 2:     a\A 3:     font-family:'Poppins', sans-serif"; }
