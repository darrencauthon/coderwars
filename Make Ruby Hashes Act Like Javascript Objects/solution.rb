require 'minitest/autorun'
require 'minitest/spec'

class Hash
  def method_missing(meth, *args, &blk)
    the_method = meth.to_s.sub('=', '').to_sym
    self[the_method] = args[0] if meth.to_s.end_with?('=')
    self[the_method]
  end
end

describe "upgrading ruby's hash" do

  let(:the_hash) { { five: 5, ten: 10 } }

  it "should allow me to call values off of hash" do
    the_hash.five.must_equal 5
    the_hash.ten.must_equal 10
  end

  it "should let me update the values" do
    the_hash.fifteen = 15
    the_hash[:fifteen].must_equal 15
  end

end
