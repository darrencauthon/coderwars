require_relative 'solution'
require 'minitest/autorun'
require 'minitest/spec'

describe "WeIrD StRiNg CaSe" do

  it "should turn String to StRiNg" do
    weirdcase('String').must_equal 'StRiNg'
  end

  it "should turn 'Weird string case' to 'WeIrD StRiNg CaSe'" do
    weirdcase('Weird string case').must_equal 'WeIrD StRiNg CaSe'
  end

  it "should turn 'a' to 'A'" do
    weirdcase('a').must_equal 'A'
  end

  it "should turn 'ab' to 'Ab'" do
    weirdcase('ab').must_equal 'Ab'
  end

  it "should turn 'Ab' to 'Ab'" do
    weirdcase('Ab').must_equal 'Ab'
  end

end
